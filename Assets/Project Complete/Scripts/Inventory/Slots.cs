using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IPointerClickHandler
{   
    [Header("Registration data")]
    public GameObject item;
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool empty;  //To know if our slot is empty
    public Transform slotIconGameObject; //We will bring the panel (Son of the slot)
    public Transform slotIconGameObject2; //We will bring the panel (second Son of the slot)

    [Header("Disabled")]
    public Sprite icon2;

    private void Start() {
        slotIconGameObject = transform.GetChild(0); //Will take the first child being the panel
        slotIconGameObject2 = transform.GetChild(1); //Will take the second child being the panel
    }

    public void UpdateSlot() //Activate the icon in the inventory
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {
        item.GetComponent<Items>().ItemUsage();
        slotIconGameObject2.GetComponent<Image>().sprite = icon2; //Activate "X" icon when the item is used
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UseItem();
    }
}