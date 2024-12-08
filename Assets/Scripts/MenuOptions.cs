using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    public AudioMixerGroup masterVolumeGroup;
    public Slider volumeSlider;

    public Slider mouseSlider;

    public GameObject optionsMenu;
    public GameObject pauseMenu;
    public GameObject mainMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnMasterVolumeChanged()
    {
        masterVolumeGroup.audioMixer.SetFloat("Volume", volumeSlider.value);
    }

    public void OnBackButtonClicked()
    {

    }
}
