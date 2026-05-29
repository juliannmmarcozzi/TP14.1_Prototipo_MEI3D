using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60;

    public UIManager ui;

    void Update()
    {
        timer -= Time.deltaTime;

        ui.UpdateTimer(timer);
    }
}
