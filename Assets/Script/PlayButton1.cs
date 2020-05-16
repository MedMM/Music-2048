using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton1 : MonoBehaviour
{
    public Animator canvasAnimator, buttonAnimator;

    public void ChangeMenuScene(string scenename)
    {
        //Application.LoadLevel(scenename);
        SceneManager.LoadScene(scenename);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touched!");
            canvasAnimator.SetBool("PlayPressed", true);
            buttonAnimator.SetBool("PlayPressed", true);


        }
    }
}
