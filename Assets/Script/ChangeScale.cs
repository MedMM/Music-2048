using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public AudioScript audioScript;
    public Text ScaleText;

    // Start is called before the first frame update
    public void ChangeCurrentScale(string ScaleName)
    {
        audioScript.ScaleName = ScaleName;
        ScaleText.text = "Current Scale: " + ScaleName;
    }
}
