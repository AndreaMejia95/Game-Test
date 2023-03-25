using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPants : MonoBehaviour
{
    public GameObject pantsOriginal;
    public GameObject pants;

    private int accNumber4;

    // Update is called once per frame
    void Update()
    {
        PantsElement();
    }

    public void LeftBtn()
    {
        if(accNumber4 > 0)
        {
            accNumber4 -=1;
        }
    }

    public void RightBtn()
    {
        if(accNumber4 < 1)
        {
            accNumber4 +=1;
        }
    }

    void PantsElement()
    {
        if(accNumber4 == 0){
            pantsOriginal.SetActive(true);
            pants.SetActive(false);
        }

        if(accNumber4 == 1){
            pantsOriginal.SetActive(false);
            pants.SetActive(true);
        }
    }
}
