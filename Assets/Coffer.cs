using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coffer : MonoBehaviour
{
    public GameObject chestClosed;
    public GameObject chestOpen;
    public Animator animator;

    public GameObject iconAxe;
    public GameObject iconShield;

    public GameObject iconPapyrus;
    public GameObject iconWooden;
    public GameObject iconCoin;



    public bool itemAxeActive = false;
    public bool itemShieldActive = false;
    public bool itemPapyrusActive = false;
    public bool itemWoodenActive = false;
    public bool itemCoinActive = false;

    

    //public ParticleSystem openChest;
    private AudioSource cofferAudio;
    public AudioClip cofferSound;
    public GameObject effectCoffer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cofferAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Axe" && Input.GetKey("q"))
        {   
            itemAxeActive = true;
            iconAxe.SetActive(true);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró Hacha");
            
            //StartCoroutine("DancingPlayer");
        }

        if(other.tag == "Shield" && Input.GetKey("q"))
        {   
            itemShieldActive = true;
            iconShield.SetActive(true);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró Escudo");
            
            //StartCoroutine("DancingPlayer");
        }

        //Otros
        if(other.tag == "Papyrus" && Input.GetKey("q"))
        {   
            itemPapyrusActive = true;
            iconPapyrus.SetActive(true);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró Papiro");
            
            //StartCoroutine("DancingPlayer");
        }

        if(other.tag == "Wooden" && Input.GetKey("q"))
        {   
            itemWoodenActive = true;
            iconWooden.SetActive(true);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró Madera");
            
            //StartCoroutine("DancingPlayer");
        }

        if(other.tag == "Coin" && Input.GetKey("q"))
        {   
            itemCoinActive = true;
            iconCoin.SetActive(true);
            Destroy(other.gameObject, 2f);
            Debug.Log("Entró Moneda");
            
        }

        if(itemAxeActive == true && itemShieldActive == true && itemPapyrusActive == true && itemWoodenActive== true && itemCoinActive == true)
        {
            StartCoroutine("DancingPlayer");
        }
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        
    }*/

    IEnumerator DancingPlayer()
    {
        yield return new WaitForSeconds(3f);
        chestClosed.SetActive(false);
        chestOpen.SetActive(true);
        animator.Play("Dancing");
        cofferAudio.PlayOneShot(cofferSound, 1.0f);
        effectCoffer.SetActive(true);
    }
}
