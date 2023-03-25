using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{   
    [Header("Registration data")]
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool playerWeapon;

    [Header("Animation")]
    public Animator animator;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equipped;

    [HideInInspector]
    public GameObject weapon;

    [HideInInspector]
    public GameObject weaponManager;

    void Start ()
    {
        weaponManager = GameObject.FindWithTag("WeaponManager");

        if(!playerWeapon)
        {
            int allWeapons = weaponManager.transform.childCount;

            for(int i = 0; i<allWeapons; i++)
            {
                if(weaponManager.transform.GetChild(i).gameObject.GetComponent<Items>().ID == ID)
                {
                    weapon = weaponManager.transform.GetChild(i).gameObject;
                }
            }
        }
    }

    private void Update()
    {
        if(equipped)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                animator.Play("Put");
                //equipped = false;
            }

            if(equipped == false)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void ItemUsage()
    {
        if( type == "Weapon")
        {   
            weapon.SetActive(true);
            weapon.GetComponent<Items>().equipped = true; //Activará el arma
        }
    }
}
