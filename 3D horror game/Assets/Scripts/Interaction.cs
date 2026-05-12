using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{   
    // Amount of haalth that the Ammo would recover for the player
    public int healAmount = 20;
    public Item Item;
    private bool yaEsta = false;

    
    public void Pickup()
    { 
        if(yaEsta)
        {
            return;
        }

        Debug.Log("se incio");

        // This GameObeject has tag "Player"?
        GameObject playerO = GameObject.FindGameObjectWithTag("Player");

        if (playerO == null)
        {
            yaEsta = false;
            return;
        }

        player playerS = playerO.GetComponent<player>();

        if (playerS == null)
        {
            yaEsta = false;
            return;
        }
                
        if(!Item.isMushroom)
        {
            //This adds 20 point for the player healt if pick up.
            playerS.addhealth(healAmount);
            Destroy(gameObject);  
            return;  
        }

        bool added = Inventory_Manager.Instance.Add(Item);

        if (added)
        {
            Destroy(gameObject);
        }
        else
        {
            yaEsta = false;
        }

    }


}
