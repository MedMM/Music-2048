using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SetGameScene : MonoBehaviour
{

    //public void changemenuscene(string scenename)
    //{
    //    application.loadlevel(scenename);
    //}

    private void Update()
    {
        if (Input.touchSupported)
        {
            Debug.Log("Touched!");
            //Application.LoadLevel("SampleScene");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
