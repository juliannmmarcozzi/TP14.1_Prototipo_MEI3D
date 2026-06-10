using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    int contador = 0;

    public UIManager ui;

    public int puntajeMaximo = 2;

    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.tag == "Coleccionable")
        {
            Destroy(objeto.gameObject);

            contador++;

            ui.UpdateScore(contador);

            if (contador >= puntajeMaximo)
            {
                ui.MostrarPantallaWin();

                Time.timeScale = 0;
            }

            Debug.Log(contador);
        }
    }
}