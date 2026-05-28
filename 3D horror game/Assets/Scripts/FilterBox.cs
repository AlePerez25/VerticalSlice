using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Item Redfilter;
    public Item Bluefilter;
    public Item Yellowfilter;
    public GameObject redbox;
    public GameObject bluebox;
    public GameObject Yellowbox;

    public void FilterText()
    {

        if(Inventory_Manager.Instance.HasItem(Bluefilter))
        {
            Destroy(bluebox);
        }

        if(Inventory_Manager.Instance.HasItem(Redfilter))
        {
            Destroy(redbox);
        }

        if(Inventory_Manager.Instance.HasItem(Yellowfilter))
        {
            Destroy(bluebox);
        }

    }
}