using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffer : MonoBehaviour
{
    public GameObject chestClosed;
    public GameObject chestOpen;
    public Animator animator;
    
    //public ParticleSystem openChest;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Item"))
        {   
            if(Input.GetKey("q"))
            {   
                //Destroy(other.gameObject);
                chestClosed.SetActive(false);
                //animator.SetBool("OtherKey", false);
                chestOpen.SetActive(true);
                Debug.Log("Entró moneda");
                Destroy(other.gameObject);
                StartCoroutine("DancingPlayer");
            }
        }
    }*/

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Axe" && Input.GetKey("q"))
        {   
              
            //animator.SetBool("OtherKey", false);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró moneda");
            StartCoroutine("DancingPlayer");
            
        }
    }

    IEnumerator DancingPlayer()
    {
        yield return new WaitForSeconds(3f);
        chestClosed.SetActive(false);
        chestOpen.SetActive(true);
        animator.Play("Dancing");
    }
}
