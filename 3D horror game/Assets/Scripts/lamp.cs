using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public GameObject luzBlanca;
    public GameObject luzBlue;
    public GameObject luzRed;
    public GameObject luzYellow;
    public GameObject BlueMush;
    public GameObject YellMush;
    public GameObject RedMush;
    public Item Redfilter;
    public Item Bluefilter;
    public Item Yellowfilter;

    public void Update()
    {   
        //turn on/off lamp with the same key in this case "Q"
        if(Input.GetKeyDown(KeyCode.Q))
        {
            NoMushroom();
            Apagar();
            luzBlanca.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Z) && Inventory_Manager.Instance.HasItem(Bluefilter))
        {
            Apagar();
            luzBlue.SetActive(true);
            NoMushroom();

            if(BlueMush != null)
            {
                BlueMush.SetActive(true);
            }
        }

        if(Input.GetKeyDown(KeyCode.X) && Inventory_Manager.Instance.HasItem(Redfilter))
        {
            Apagar();
            luzRed.SetActive(true);
            NoMushroom();

            if(RedMush != null)
            {
                RedMush.SetActive(true);
            }
        }

        if(Input.GetKeyDown(KeyCode.C) && Inventory_Manager.Instance.HasItem(Yellowfilter))
        {
            Apagar();
            luzYellow.SetActive(true);
            NoMushroom();

            if(YellMush != null)
            {
                YellMush.SetActive(true);
            }
        }
    }

    public void Apagar()
    {
        luzBlanca.SetActive(false);
        luzBlue.SetActive(false);
        luzRed.SetActive(false);
        luzYellow.SetActive(false);
    }

    public void NoMushroom()
    {
        if(YellMush != null)
        {
            YellMush.SetActive(false);
        }

        if(RedMush != null)
        {
            RedMush.SetActive(false); 
        }

        if(BlueMush != null)
        {
            BlueMush.SetActive(false);
        }
    }

}
