using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accesories : MonoBehaviour
{   
    
    public GameObject hat;

    private int accNumber;

    // Update is called once per frame
    void Update()
    {
        HatElement();
    }

    public void LeftBtn()
    {
        if(accNumber > 0)
        {
            accNumber -=1;
        }
    }

    public void RightBtn()
    {
        if(accNumber < 1)
        {
            accNumber +=1;
        }
    }

    void HatElement()
    {
        if(accNumber == 0){
            hat.SetActive(false);
        }

        if(accNumber == 1){
            hat.SetActive(true);
        }
    }
}
