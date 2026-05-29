using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aqui : MonoBehaviour
{
    public Item Redfilter;
    public Item Bluefilter;
    public Item Yellowfilter;
    public GameObject redbox;
    public GameObject bluebox;
    public GameObject yellowbox;
    public TextMeshProUGUI  redboxText;
    public TextMeshProUGUI  blueboxText;
    public TextMeshProUGUI  yellowboxText;
    
    public float timer = 5f;
    bool  counting = false;

    private void Start ()
    {
        blueboxText.gameObject.SetActive(false);
        yellowboxText.gameObject.SetActive(false);
        redboxText.gameObject.SetActive(false);
    }

    private void Update()
    {
        FilterText();

        if(counting)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                blueboxText.gameObject.SetActive(false);
                yellowboxText.gameObject.SetActive(false);
                redboxText.gameObject.SetActive(false);
                counting = false;
            }
        }
    }  

    public void FilterText()
    {

        if(Inventory_Manager.Instance.HasItem(Bluefilter) && bluebox != null)
        {
            Debug.Log("Funcion funcionando");
            Destroy(bluebox);
            bluebox = null;

            blueboxText.gameObject.SetActive(true);
            timer = 5f;
            counting = true;

        }

        if(Inventory_Manager.Instance.HasItem(Redfilter) && redbox != null)
        {
            Destroy(redbox);
            redbox = null;

            redboxText.gameObject.SetActive(true);
            timer = 5f;
            counting = true;
        }

        if(Inventory_Manager.Instance.HasItem(Yellowfilter) && yellowbox != null)
        {
            Debug.Log("Funcion funcionando");
            Destroy(yellowbox);
            yellowbox = null;

            yellowboxText.gameObject.SetActive(true);
            timer = 5f;
            counting = true;
        }

    }
}