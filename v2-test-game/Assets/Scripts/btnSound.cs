using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnSound : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip ClickFX;

    public void ClickSound()
    {
        mySound.PlayOneShot(ClickFX);
    }

}
