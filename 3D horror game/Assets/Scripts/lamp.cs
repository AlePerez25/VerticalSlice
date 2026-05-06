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







    public void Update()
    {   
        //turn on/off lamp with the same key in this case "Q"
        if(Input.GetKeyDown(KeyCode.Q))
        {
            NoMushroom();
            Apagar();
            luzBlanca.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            Apagar();
            luzBlue.SetActive(true);
            NoMushroom();
            BlueMush.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            Apagar();
            luzRed.SetActive(true);
            NoMushroom();
            RedMush.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            Apagar();
            luzYellow.SetActive(true);
            NoMushroom();
            YellMush.SetActive(true);
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
        YellMush.SetActive(false);
        RedMush.SetActive(false);
        BlueMush.SetActive(false);
    }

    



}
