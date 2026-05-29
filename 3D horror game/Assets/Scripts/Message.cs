using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Message : MonoBehaviour
{
    [SerializeField] private GameObject FilterTex;

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("Player") && FilterTex != null)
        {
            Debug.Log("nooo");
            FilterTex.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {   
        if (other.CompareTag("Player") && FilterTex != null)
        {
            FilterTex.SetActive(false);
            Debug.Log("nooo");
        }
    }
}
