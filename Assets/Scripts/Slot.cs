using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Inventory inventory;
    Stats stats;

    public int numSlot;

    void Start()
    {
        inventory = Inventory.instance;
        stats = Stats.instance;
    }

    public void UseItem()
    {
        if(stats.collectedItems<10 && inventory.items[numSlot].type == ItemType.Gimlet && inventory.items[numSlot].amount == 1)
        {
            stats.AddItems(3);
            inventory.EmptyStlo(numSlot, GetComponent<Image>());
        }

        if(stats.collectedItems<10 && inventory.items[numSlot].type == ItemType.Gimlet && inventory.items[numSlot].amount > 1)
        {
            stats.AddItems(3);
            inventory.items[numSlot].amount -= 1;
        }
       
        
    }
}
