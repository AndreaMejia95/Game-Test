using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
     public GameObject bag;

    private int accNumber5;

    // Update is called once per frame
    void Update()
    {
        HatElement();
    }

    public void LeftBtn()
    {
        if(accNumber5 > 0)
        {
            accNumber5 -=1;
        }
    }

    public void RightBtn()
    {
        if(accNumber5 < 1)
        {
            accNumber5 +=1;
        }
    }

    void HatElement()
    {
        if(accNumber5 == 0){
            bag.SetActive(false);
        }

        if(accNumber5 == 1){
            bag.SetActive(true);
        }
    }
}
