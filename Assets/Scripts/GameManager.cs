using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60;
    public UIManager ui;

    private bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
        juegoTerminado = false;

        if (ui != null)
        {
            ui.UpdateTimer(timer);
        }
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                juegoTerminado = true;

                ui.UpdateTimer(timer);
                ui.MostrarPantallaGameOver();

                Time.timeScale = 0;
            }
            else
            {
                ui.UpdateTimer(timer);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}