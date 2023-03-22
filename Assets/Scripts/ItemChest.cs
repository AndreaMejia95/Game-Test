using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChest : MonoBehaviour
{   
    public GameObject canvasChest,item1,item2,item3,item4,item5;
    public GameObject itemIv1, itemIv2, itemIv3, itemIv4, itemIv5;
    public Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        putObject();
    }

    

    /*private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            canvas.SetActive(true);
        }
    }*/

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            canvasChest.SetActive(true);
        }
    }

    private void putObject()
    {   
        if(Input.GetKey("r"))
        {      
            animator.Play("Put");
            animator.SetBool("OtherKey", false);
            item1.SetActive(true);
            itemIv1.SetActive(false);
        }
    }

 
}
