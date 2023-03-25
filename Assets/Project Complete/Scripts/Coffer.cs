using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffer : MonoBehaviour
{   
    [Header("Animation")]
    public Animator animator;
    
    [Header("Elements")]
    public GameObject chestClosed;
    public GameObject chestOpen;
    public GameObject winner;

    [Header("Icons")]
    public GameObject iconAxe;
    public GameObject iconShield;
    public GameObject iconPapyrus;
    public GameObject iconWooden;
    public GameObject iconCoin;

    [Header("Sounds")]
    public AudioClip cofferSound;
    public AudioClip addItemSound;
    private AudioSource cofferAudio;

    [Header("Effects")]
    public GameObject effectCoffer;

    //Checking of the 5 items for opening the box
    private bool itemAxeActive = false;
    private bool itemShieldActive = false;
    private bool itemPapyrusActive = false;
    private bool itemWoodenActive = false;
    private bool itemCoinActive = false;

    void Start()
    {
        cofferAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Axe" && Input.GetKey("q"))
        {   
            itemAxeActive = true;
            iconAxe.SetActive(true);
            Destroy(other.gameObject, 2f);
            cofferAudio.PlayOneShot(addItemSound, .3f);
        }

        if(other.tag == "Shield" && Input.GetKey("q"))
        {   
            itemShieldActive = true;
            iconShield.SetActive(true);
            Destroy(other.gameObject, 2f);
            cofferAudio.PlayOneShot(addItemSound, .3f);
        }

        if(other.tag == "Papyrus" && Input.GetKey("q"))
        {   
            itemPapyrusActive = true;
            iconPapyrus.SetActive(true);
            Destroy(other.gameObject, 2f);
            cofferAudio.PlayOneShot(addItemSound, .3f);
        }

        if(other.tag == "Wooden" && Input.GetKey("q"))
        {   
            itemWoodenActive = true;
            iconWooden.SetActive(true);
            Destroy(other.gameObject, 2f);
            cofferAudio.PlayOneShot(addItemSound, .3f);
        }

        if(other.tag == "Coin" && Input.GetKey("q"))
        {   
            itemCoinActive = true;
            iconCoin.SetActive(true);
            Destroy(other.gameObject, 2f);
            cofferAudio.PlayOneShot(addItemSound, .3f);
        }

        if(itemAxeActive == true && itemShieldActive == true && itemPapyrusActive == true && itemWoodenActive== true && itemCoinActive == true)
        {   
            StartCoroutine("DancingPlayer");
        }
    }

    IEnumerator DancingPlayer()
    {   
        yield return new WaitForSeconds(3f);
        chestClosed.SetActive(false);
        chestOpen.SetActive(true);
        animator.Play("Dancing");
        cofferAudio.PlayOneShot(cofferSound, .2f);
        effectCoffer.SetActive(true);
        winner.SetActive(true);
    }

    //Exit the game
    public void OutGame()
    {
        Application.Quit();
    }
}