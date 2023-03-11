using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioSource menuSound;
    public Slider volumeSlider;

    void Start()
    {
        menuSound = GetComponent<AudioSource>();
        volumeSlider.value = menuSound.volume;
    }

    public void SetVolumeWithSlider(float value)
    {
        menuSound.volume = value;
    }
}
