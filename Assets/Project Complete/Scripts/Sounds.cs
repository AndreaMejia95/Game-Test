using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{   
    [Header ("AudioSource")]
    public AudioSource sound1;//CreateGameObject Empty and add audiosource
    public AudioSource sound2;//CreateGameObject Empty and add audiosource

    [Header ("Audio")]
    public AudioClip soundCursor;
    public AudioClip soundBtn;
    
    //This function is called from the Button through the component Event Trigger.
    public void SoundCursorP()
    {
        sound2.clip = soundCursor;
        //Turn sound on and off
        sound2.enabled = false;
        sound2.enabled = true;
    }

    public void SoundButton()
    {
        sound1.clip = soundBtn;
        //Turn sound on and off
        sound1.enabled = false;
        sound1.enabled = true;
    }

    
}
