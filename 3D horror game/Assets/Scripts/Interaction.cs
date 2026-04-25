using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{   
    // Amount of haalth that the Ammo would recover for the player
    public int healAmount = 20;
    
    public void Pickup()
    { 
        // This GameObeject has tag "Player"?
        GameObject playerO = GameObject.FindGameObjectWithTag("Player");

        if (playerO != null)
        {   
            //This component has the script "player"?
            player playerS = playerO.GetComponent<player>();
            
            if(playerS != null)
            {
                //This adds 20 point for the player healt if pick up.
                playerS.addhealth(healAmount);
            }
        }

        //Desapers object from terrian.
        Destroy(gameObject);  
       
    }
}
