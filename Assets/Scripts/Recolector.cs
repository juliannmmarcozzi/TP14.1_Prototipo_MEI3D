using UnityEngine;

public class Recolector : MonoBehaviour
{
    public UIManager ui;
    public int puntajeMaximo = 3;

    private int contador = 0;
    private bool juegoGanado = false;

    void Start()
    {
        contador = 0;
        juegoGanado = false;

        if (ui != null)
        {
            ui.UpdateScore(contador);
        }
    }

    void OnTriggerEnter(Collider objeto)
    {
        if (juegoGanado) return;

        if (objeto.CompareTag("Coleccionable"))
        {
            objeto.tag = "Untagged";

            contador++;

            Debug.Log("Agarré: " + objeto.name + " | Contador: " + contador + " / Maximo: " + puntajeMaximo);

            if (ui != null)
            {
                ui.UpdateScore(contador);
            }
            else
            {
                Debug.LogError("FALTA ASIGNAR UI MANAGER EN EL FPSCONTROLLER");
            }

            Destroy(objeto.gameObject);

            if (contador >= puntajeMaximo)
            {
                juegoGanado = true;

                if (ui != null)
                {
                    ui.MostrarPantallaWin();
                }

                Time.timeScale = 0;
            }
        }
    }
}