using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsOpener : MonoBehaviour
{
    public GameObject SettingsPanel;

    public void OpenSettings()
    {
        if (SettingsPanel != null )
        {
            bool isActive = SettingsPanel.activeSelf;
            SettingsPanel.SetActive(!isActive);
        }
    }
}
