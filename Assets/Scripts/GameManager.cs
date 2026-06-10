using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60;

    public UIManager ui;

    bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            ui.UpdateTimer(timer);

            if (timer <= 0)
            {
                timer = 0;

                ui.UpdateTimer(timer);

                ui.MostrarPantallaGameOver();

                juegoTerminado = true;

                Time.timeScale = 0;
            }
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}