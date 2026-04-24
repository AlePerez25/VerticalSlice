using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //Esto le pregunta a al ebjeto con el que coliiciona si tienen el script player
            //si si lo tiene entonces pasa a la siguiente condicion.
            player p = other.GetComponent<player>();

            if(p != null)
            {
                p.TakeDamage(10);
            }

        }
    }
}

