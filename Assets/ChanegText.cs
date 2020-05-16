using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanegText : MonoBehaviour
{
    void Start()
    {
        Dictionary<int, string> words = new Dictionary<int, string>();
        words.Add(0, " ( ͡° ͜ʖ ͡°) ");
        words.Add(1, "Chill");
        words.Add(2, "Rest");
        words.Add(3, "Aesthetic");
        words.Add(4, "Mind");
        words.Add(5, "puzzling");
        words.Add(6, "Secret");
        words.Add(7, "25");
        words.Add(8, "(UwU)");
        words.Add(9, "Uhhhh.....");
        words.Add(10, "Again");
        words.Add(11, "Relax");
        words.Add(12, "Paintashop");
        words.Add(13, "Надзвичайно");
        words.Add(14, "Word");
        words.Add(15, "Sky");
        words.Add(16, "Emathetic");
        words.Add(17, "Aimlessness");
        words.Add(18, "ReadLine");
        words.Add(19, "Indeed");
        words.Add(20, "And Again");
        words.Add(21, "");
        words.Add(22, "Ooaoaa");
        words.Add(23, "Виталик привет");
        //Random.Range(1, words.Count)



        // Случайая фраза из списка
        GameObject.Find("Text").GetComponentInChildren<Text>().text = words[Random.Range(1, words.Count)];
     
    }
}
