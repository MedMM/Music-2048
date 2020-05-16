using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioScript audioScript;
    public Text VolumeText, PitchText, ScaleText;
    public Slider VolumeSlider, PitchSlider;
        


    private void Start()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("VolumeData");
        audioMixer.SetFloat("MixerVolume", PlayerPrefs.GetFloat("VolumeData"));


        PitchSlider.value = PlayerPrefs.GetFloat("PitchData");
        audioMixer.SetFloat("MixerPitch", PlayerPrefs.GetFloat("PitchData"));

        ScaleText.text = "Current Scale: " + PlayerPrefs.GetString("ScaleNameData");
        audioScript.ScaleName = PlayerPrefs.GetString("ScaleNameData");
    }



    public void ChangeVolumeValue(float value)
    {
        audioMixer.SetFloat("MixerVolume", value);
        PlayerPrefs.SetFloat("VolumeData", value);
        PlayerPrefs.Save();
    }

    public void ChangePitchValue(float value)
    {

        audioMixer.SetFloat("MixerPitch", value);
        PitchText.text = "Pitch: " + value.ToString("0.00");
        PlayerPrefs.SetFloat("PitchData", value);
        PlayerPrefs.Save();
        //audioMixer.SetFloat("MixerPitch", value);

    }

    public void ChangeCurrentScale(string ScaleName)
    {
        audioScript.ScaleName = ScaleName;
        ScaleText.text = "Current Scale: " + ScaleName;
        PlayerPrefs.SetString("ScaleNameData", ScaleName);
        PlayerPrefs.Save();
    }
}
