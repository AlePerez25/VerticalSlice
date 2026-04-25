using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class player : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField]public GameObject cursorui;
    [SerializeField]private Transform _cameraTrans;
    
    public ParticleSystem muzzle;
    public float impact = 0;
    public GameObject Enemy;
    
    public int health = 100;
    public int Max = 100;
    public int Min = 0;


    void Start()
    {
        _cameraTrans = Camera.main.transform;
        cursorui.SetActive(true);
    }

    void Update()
    {
        //si el jugador preciona el mouse
        if (Input.GetMouseButtonDown(0))
        {
            //Raycast system
            Ray ray = new Ray(_cameraTrans.position, _cameraTrans.forward);
            // get information back from the raycast.
            RaycastHit hit;

            // From raycast unity documentation
            // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Physics.Raycast.html

            //for Ammon/ Interactive items.
            if (Physics.Raycast(ray, out hit, 5f))
            {
                //this item has the ItemPickUp script? 
                ItemPickUp pickup = hit.collider.GetComponent<ItemPickUp>();

                if (pickup != null)
                {
                    //PickUp item
                    pickup.Pickup();
                }
            }

            //For shoot monster
            if (Physics.Raycast(ray, out hit, 15f) && hit.collider.CompareTag("Monster"))
            {
                //Play muzzle particle
                muzzle.Play();

                Debug.Log("aaaaah perro");

                //this item has the monster script? 
                monster zombie = hit.collider.GetComponent<monster>();

                if(zombie != null)
                {
                    //empuja method
                    Empuja();
                }

            }


        }

        //This method is to push away the monster when player shoot it.
        void Empuja()
        {
            Enemy.transform.position += transform.forward * Time.deltaTime * impact;
        }
        
        //This updates the UI for health.
        _pointsText.text = "Health: " + health;

    }

    // method call by interaction script if payer pick up a ammo for more life.
    public void addhealth(int amount)
    {
        health += amount;

        if (health > Max)
        {
            health = Max;
        }
    }

    //method call by monster script, if player is attacked by the monster.
    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health < Min)
        {
            health = Min;
        }

        
    }
}
