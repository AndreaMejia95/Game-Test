using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceElements : MonoBehaviour
{   
    [Header ("Elements")]
    public GameObject btnAccesor;
    public GameObject cameraPlayer;
    public GameObject cameraAccessories;
    public GameObject canvasAccessories;

    [Header ("Script Component")]
    public PlayerController scriptPlayer;

    public void ActiveAccessories(){
        canvasAccessories.SetActive(true);      //Active Canvas Accessories
        scriptPlayer.enabled = false;           //Desactive Script Move Player
        btnAccesor.SetActive(false);            //Desactive Button Accessories
        cameraPlayer.SetActive(false);          //Desactive Camera main
        cameraAccessories.SetActive(true);      //Active Camera Secondary
    }

    public void DesactiveAccessories(){
        canvasAccessories.SetActive(false);      
        scriptPlayer.enabled = true;                
        btnAccesor.SetActive(true);
        cameraPlayer.SetActive(true);
        cameraAccessories.SetActive(false);
    }
}