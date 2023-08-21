using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float OldVolume;
    void Start()
    {
        OldVolume = slider.value;
        if (!PlayerPrefs.HasKey("volume"))
        {
            slider.value = 1;
        }
        else
        {
            slider.value = PlayerPrefs.GetFloat("volume");
        }
    }
    void Update()
    {
        if (OldVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            OldVolume = slider.value;
        }
    }
}
