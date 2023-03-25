using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{
    [Header("Elements")]
    public GameObject inventory;
    public GameObject slotHolder;
    public GameObject accesoriesBtn;

    [Header("Sounds")]
    public AudioClip inventSound;
    public AudioClip getItemSound;
    private AudioSource inventAudio;

    private bool inventoryEnabled;  //Inventory active - deactivated
    private GameObject[] slot;      //Array Slots
    private int allSlots;           //Number of slots
    private int enabledSlots;       //which slots are available

    void Start()
    {   
        inventAudio = GetComponent<AudioSource>();

        //Will review how many children slots the slotHolder
        allSlots = slotHolder.transform.childCount;

        slot = new GameObject[allSlots]; //Assign the slots to the array

        for(int i=0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject; //Insert gameobjects to slots

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
            //Will check whether the inventory is open or not
            inventoryEnabled =! inventoryEnabled;
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
            GameObject itemPickedUp = other.gameObject; //Save the object with which it has collided

            Items item = itemPickedUp.GetComponent<Items>(); //intance ítem

            //We call the parameters of the script item
            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }

    public void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for(int i=0; i < allSlots; i++)
        {
            if(slot[i].GetComponent<Slots>().empty) //It will search if the slot is empty
            {
                itemObject.GetComponent<Items>().pickedUp = true;

                slot[i].GetComponent<Slots>().item = itemObject;
                slot[i].GetComponent<Slots>().ID = itemID;
                slot[i].GetComponent<Slots>().type = itemType;
                slot[i].GetComponent<Slots>().description = itemDescription;
                slot[i].GetComponent<Slots>().icon = itemIcon;

                //Save in the parent slots
                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slots>().UpdateSlot(); //We call the script method slots

                slot[i].GetComponent<Slots>().empty = false; //No longer empty, no item is assigned
                return; //This will avoid a loop by filling each slot with the same element.
            }
        }
    }
}