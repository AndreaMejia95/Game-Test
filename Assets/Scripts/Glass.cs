using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
      
    public GameObject glasses;

    private int accNumber2;

    // Update is called once per frame
    void Update()
    {
        GlassesElement();
    }

    public void LeftBtn()
    {
        if(accNumber2 > 0)
        {
            accNumber2 -=1;
        }
    }

    public void RightBtn()
    {
        if(accNumber2 < 1)
        {
            accNumber2 +=1;
        }
    }

    void GlassesElement()
    {
        if(accNumber2 == 0){
            glasses.SetActive(false);
        }

        if(accNumber2 == 1){
            glasses.SetActive(true);
        }
    }
}
