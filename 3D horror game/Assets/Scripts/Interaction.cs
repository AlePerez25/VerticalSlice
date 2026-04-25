using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int healAmount = 20;
    
    public void Pickup()
    { 
        GameObject playerO = GameObject.FindGameObjectWithTag("Player");

        if (playerO != null)
        {
            player playerS = playerO.GetComponent<player>();

            if(playerS != null)
            {
                playerS.addhealth(healAmount);
            }
        }

        Destroy(gameObject);  
       
    }
}
