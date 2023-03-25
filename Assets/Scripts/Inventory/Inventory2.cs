using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{

    private bool inventoryEnabled;

    public GameObject inventory, accesoriesBtn;

    private int allSlots;

    private int enabledSlots; //Para saber que slots están disponibles

    private GameObject[] slot;

    public GameObject slotHolder;

    private AudioSource inventAudio;
    public AudioClip inventSound;
    public AudioClip getItemSound;

    void Start()
    {   
        inventAudio = GetComponent<AudioSource>();

        allSlots = slotHolder.transform.childCount; //Revisará cuantos hijos slots tiene el slotHolder

        slot = new GameObject[allSlots]; //asignamos los slots al array

        for(int i=0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject; //Insertará los gameobjects a los slots

            if(slot[i].GetComponent<Slots>().item == null)
            {
                slot[i].GetComponent<Slots>().empty = true;
            }
        }

        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled =! inventoryEnabled; //Comprobará si el inventario está abierto o no
        }

        if(inventoryEnabled == true)
        {
            inventory.SetActive(true);
            accesoriesBtn.SetActive(false);
            
        } else{
            inventory.SetActive(false);
            accesoriesBtn.SetActive(true);
        }

        soundsInvent();
    }

    private void soundsInvent()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
           inventAudio.PlayOneShot(inventSound, .2f);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Item")
        {
            inventAudio.PlayOneShot(getItemSound, .3f);
            GameObject itemPickedUp = other.gameObject; //Guardamos el objeto con el que se ha colicionado

            Items item = itemPickedUp.GetComponent<Items>(); //Instanciamos ítem

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon); //Llamamos los parámetros del script item

        }
    }

    public void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for(int i=0; i < allSlots; i++)
        {
            if(slot[i].GetComponent<Slots>().empty) //Buscará si el slot está vacío
            {
                itemObject.GetComponent<Items>().pickedUp = true;

                slot[i].GetComponent<Slots>().item = itemObject;
                slot[i].GetComponent<Slots>().ID = itemID;
                slot[i].GetComponent<Slots>().type = itemType;
                slot[i].GetComponent<Slots>().description = itemDescription;
                slot[i].GetComponent<Slots>().icon = itemIcon;

                //Guardamos en los slots padres
                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slots>().UpdateSlot(); //Llamamos el método del script slots

                slot[i].GetComponent<Slots>().empty = false; //Ya no está vacía, no se asigna item
                return; //Con esto se evitará un bucle llenándose cada slot con el mismo elemento
            }
        }
    }
}
