using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class player : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    public GameObject cursorui;
    private Transform _cameraTrans;
    
    public ParticleSystem muzzle;
    public float impact = 0;
    public GameObject Enemy;
    
    public int health = 100;
    public int Max = 100;
    public int Min = 0;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _cameraTrans = Camera.main.transform;
        cursorui.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = new Ray(_cameraTrans.position, _cameraTrans.forward);
            // get information back from the raycast.
            RaycastHit hit;

            // From raycast unity documentation
            // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Physics.Raycast.html
            if (Physics.Raycast(ray, out hit, 5f))
            {
                
                ItemPickUp pickup = hit.collider.GetComponent<ItemPickUp>();

                if (pickup != null)
                {
                    pickup.Pickup();
                }
            }

            if (Physics.Raycast(ray, out hit, 15f) && hit.collider.CompareTag("Monster"))
            {
                muzzle.Play();

                Debug.Log("pinche perro");

                monster zombie = hit.collider.GetComponent<monster>();

                if(zombie != null)
                {
                    Empuja();
                }

            }


        }

        void Empuja()
        {
            Enemy.transform.position += transform.forward * Time.deltaTime * impact;
        }

        _pointsText.text = "Health: " + health;

    }

    public void addhealth(int amount)
    {
        health += amount;

        if (health > Max)
        {
            health = Max;
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health < Min)
        {
            health = Min;
        }

        
    }
}
