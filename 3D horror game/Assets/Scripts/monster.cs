using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
   public int damage = 10;
   private float timer = 0f;

   void Update()
   {
    //timer 
    timer += Time.deltaTime;
   }

    //OnTriggerStay is called on every physics update while a collider remains touching the trigger.
    // (unity documentation)
    // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/MonoBehaviour.OnTriggerStay.html
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && timer > 1.0f)
        {
            //Esto le pregunta a al ebjeto con el que coliiciona si tienen el script player
            //si si lo tiene entonces pasa a la siguiente condicion.
            //This component has the script "player"?
            player p = other.GetComponent<player>();

            if(p != null)
            {
                //method from player script "Take damage"
                p.TakeDamage(damage);
                timer = 0f;
            }

        }
    }
}

