using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum ItemType
{
    none,
    log,
    Gimlet,
    Axe,
    File,
    AxeCurve,
    HandDrill
}

public class Inventory : MonoBehaviour
{
    public static Inventory instance; //Instanciamos el script para poder llamarlo
    public Item[] items;
    
    private void Awake()
    {
        instance = this;
    }

    public void EmptyStlo(int numSlot, Image img)
    {
        items[numSlot].isFull = false;
        items[numSlot].amount = 1;
        items[numSlot].type = ItemType.none;
        img.enabled = false;
    }
}

[System.Serializable]
public class Item
{
    public bool isFull;
    public int amount;
    public ItemType type;
    public string name;
    public GameObject slotSprite;
}
