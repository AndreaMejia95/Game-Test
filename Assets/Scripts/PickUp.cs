using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    Inventory inventory;
    public ParticleSystem particle;
    public Sprite sprite;
    public ItemType type;
    public string nameItem;
    

    void Start()
    {
        inventory = Inventory.instance;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {   
            for(int i=0; i<inventory.items.Length; i++)
            {
                if(inventory.items[i].isFull == false) //Buscará si hay un espacio vacío en las cajas
                {
                    Debug.Log("Item añadido");
                    inventory.items[i].isFull = true;
                    inventory.items[i].amount = 1;
                    inventory.items[i].type = type;
                    inventory.items[i].name = nameItem;
                    inventory.items[i].slotSprite.GetComponent<Image>().sprite = sprite;
                    inventory.items[i].slotSprite.GetComponent<Image>().enabled = true;
                    Destroy(gameObject);
                    Instantiate(particle, transform.position, Quaternion.identity);
                    break;
                }
            }
        }
    }
}
