using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource source;
    void Start()
    {
        if (!PlayerPrefs.HasKey("volume"))
        {
            source.volume = 1;
        }
    }
    void Update()
    {
        source.volume = PlayerPrefs.GetFloat("volume");
    }
}
