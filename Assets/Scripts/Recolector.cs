using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    int contador = 0;

    void OnTriggerEnter(Collider objeto)
    {
        if(objeto.tag == "Coleccionable")
        {
            Destroy(objeto.gameObject);

            contador = contador + 1;

            Debug.Log(contador);
        }
    }
}