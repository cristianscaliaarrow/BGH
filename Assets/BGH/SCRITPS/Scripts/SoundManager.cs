using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;
    public AudioSource audio;

    public void Start()
    {
        instance = this;
    }

    public static void PlayCollectable()
    {
        instance.audio.Play();
    }

}
