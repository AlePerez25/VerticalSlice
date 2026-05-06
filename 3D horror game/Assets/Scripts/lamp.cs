using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public GameObject luzBlanca;
    public GameObject luzBlue;
    public GameObject luzRed;
    public GameObject luzYellow;




    public void Update()
    {   
        //turn on/off lamp with the same key in this case "Q"
        if(Input.GetKeyDown(KeyCode.Q))
        {
            luzBlanca.SetActive(!luzBlanca.activeSelf);
        }

        /*if(Input.GetKeyDown(KeyCode.W))
        {
            luzBlue.SetActive(!luzBlue.activeSelf);
        }*/

        if(Input.GetKeyDown(KeyCode.E))
        {
            luzRed.SetActive(!luzRed.activeSelf);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            luzYellow.SetActive(!luzYellow.activeSelf);
        }
    }

    



}
