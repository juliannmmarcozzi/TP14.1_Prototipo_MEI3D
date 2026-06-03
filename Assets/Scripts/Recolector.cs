using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    int contador = 0;

    public int totalPendrives = 2; // cantidad total en la escena

    public UIManager ui;

    public bool gano = false;

    void OnTriggerEnter(Collider objeto)
    {
        if(objeto.tag == "Coleccionable")
        {
            Destroy(objeto.gameObject);

            contador++;

            ui.UpdateScore(contador);

            if(contador >= totalPendrives)
            {
                gano = true;
                ui.ShowWinMessage();
            }
        }
    }
}