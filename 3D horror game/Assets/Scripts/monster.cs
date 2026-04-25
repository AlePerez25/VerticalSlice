using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
   public int damage = 10;
   private float timer = 0f;

   void Update()
   {
    timer += Time.deltaTime;
   }

    //OnTriggerStay is called on every physics update while a collider remains touching the trigger.
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && timer > 1.0f)
        {
            //Esto le pregunta a al ebjeto con el que coliiciona si tienen el script player
            //si si lo tiene entonces pasa a la siguiente condicion.
            player p = other.GetComponent<player>();

            if(p != null)
            {
                p.TakeDamage(damage);
                timer = 0f;
            }

        }
    }
}

