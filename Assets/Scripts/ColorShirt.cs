using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShirt : MonoBehaviour
{
    public GameObject shirt;

    private int accNumber3;

    // Update is called once per frame
    void Update()
    {
        ShirtElement();
    }

    public void LeftBtn()
    {
        if(accNumber3> 0)
        {
            accNumber3 -=1;
        }
    }

    public void RightBtn()
    {
        if(accNumber3 < 1)
        {
            accNumber3 +=1;
        }
    }

    void ShirtElement()
    {
        if(accNumber3 == 0){
            shirt.SetActive(false);
        }

        if(accNumber3 == 1){
            shirt.SetActive(true);
        }
    }
}
