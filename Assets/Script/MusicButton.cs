using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public AudioScript audioScript;
    public AudioResources audioResources;

    public void MusicButtonPressed()
    {
        audioScript.PlayPattern(audioResources.Riff[3]);
    }
}
