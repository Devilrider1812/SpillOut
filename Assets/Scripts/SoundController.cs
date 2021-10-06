using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController soundctrl = null;
    public AudioSource audioSrc;
    private void Awake()
    {
        if (soundctrl == null)
        {
            soundctrl = this;
        }
        else if (soundctrl != this)
        {
            Destroy(gameObject);
        }
    }

    public void playClip(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
}
