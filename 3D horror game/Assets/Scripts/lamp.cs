using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public GameObject luz;

    public void Update()
    {   
        //turn on/off lamp with the same key in this case "Q"
        if(Input.GetKeyDown(KeyCode.Q))
        {
            luz.SetActive(!luz.activeSelf);
        }
    }

    



}
