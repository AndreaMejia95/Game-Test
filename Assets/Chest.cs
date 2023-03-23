using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chestClosed;
    public GameObject chestOpen;
    
    public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Fire"))
        {   
            if(Input.GetKey("r"))
            {
                animator.Play("Put");
                chestClosed.SetActive(false);
                //animator.SetBool("OtherKey", false);
                chestOpen.SetActive(true);
            }
        }
    }
}
