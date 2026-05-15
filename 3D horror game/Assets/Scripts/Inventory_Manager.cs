using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Inventory_Manager : MonoBehaviour
{
    public static Inventory_Manager Instance;
    public List<Item> Items = new List<Item>();
    public Transform Content;
    public GameObject InventoryItem;
    public int Max = 8;

    public bool IsFilter;

    private void Awake()
    {
        if (Instance != null &&  Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public bool Add(Item item)
    {
        if (Items.Count >= Max)
        {
            WinScene();
            return false;
        }
        
        Items.Add(item);

        if(!item.IsFilter)
        {
            ListItem();
        }

        return true;
    }

    public bool PlayerHasItem(Item item)
    {
        return Items.Contains(item);
    }

    
    public void ListItem()
    {
        //Debug.Log("ListItem se está ejecutando");
        
        // This avoid to have duplicate items when we only click 1 of them
        foreach (Transform item in Content)
        {
            Destroy(item.gameObject);
        }

        //This creates the new cube items of UI acording to the list of items
        foreach (var item in Items)
        {
            if(item.IsFilter)
            {
                continue;
            }

            //This creates the prefab child for "Content"
            GameObject obj = Instantiate(InventoryItem, Content);

            //Find and apply object information (Image/icon and name)
            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            //This makes the image and name visible on the screen.
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;

        }
    }

    public bool HasItem(Item item)
    {
        return Items.Contains(item);
    }
    
    public void WinScene()
    {
        SceneManager.LoadScene(3);
    }
}
