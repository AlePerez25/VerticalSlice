using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aqui : MonoBehaviour
{
    public Item Redfilter;
    public Item Bluefilter;
    public Item Yellowfilter;
    public GameObject redbox;
    public GameObject bluebox;
    public GameObject yellowbox;

    public void FilterText()
    {

        if(Inventory_Manager.Instance.HasItem(Bluefilter))
        {
            Debug.Log("Funcion funcionando");
            Destroy(bluebox);
        }

        if(Inventory_Manager.Instance.HasItem(Redfilter))
        {
            Destroy(redbox);
        }

        if(Inventory_Manager.Instance.HasItem(Yellowfilter))
        {
            Debug.Log("Funcion funcionando");
            Destroy(yellowbox);
        }

    }
}