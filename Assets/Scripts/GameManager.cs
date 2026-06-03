using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60;

    public UIManager ui;

    public Recolector recolector;

    bool gameOver = false;

    void Update()
    {
        if (gameOver)
            return;

        if (recolector.gano)
        {
            gameOver = true;
            ui.ShowWinMessage();
            return;
        }

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;
            gameOver = true;
            ui.ShowLoseMessage();
            return;
        }

        ui.UpdateTimer(timer);
    }
}