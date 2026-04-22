using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject luz;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            luz.SetActive(!luz.activeSelf);
        }
    }

    



}
