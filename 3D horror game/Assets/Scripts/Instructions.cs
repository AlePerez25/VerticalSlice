using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

    public GameObject Paper;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Paper.SetActive(!Paper.activeSelf);
        }
    }



}
