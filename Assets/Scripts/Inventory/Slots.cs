using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    
    public int ID;
    public string type;
    public string description;
    
    public bool empty;  //Para saber si nuestro slot está vacío

    public Sprite icon;

    public Transform slotIconGameObject; //Traeremos el panel (Hijo del slot)

    private void Start() {
        slotIconGameObject = transform.GetChild(0); //Tomará al primer hijo siendo este el panel
    }

    public void UpdateSlot() //Activará el ícono en el inventario
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {
        item.GetComponent<Items>().ItemUsage();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UseItem();
        //Destroy(gameObject);
        //item.SetActive(false); //Desactiva el slot del inventario
    }
}
