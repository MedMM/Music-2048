using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioScript : MonoBehaviour
{
    public string ScaleName; //Name of current scale
    public AudioResources audioResources; 
    public AudioSource audioSource;
    public AudioClip[] notes; //Array of all notes
    public int[] Pattern = null;
    public int PatternIndex = 0;
    public int RiffNumber; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) PlayPattern(audioResources.Riff[RiffNumber]);

        if (Input.GetKeyDown(KeyCode.Q)) Merged();
    }
    //Do every time when objects merge
    public void Merged()
    {
        PlayNote();
    }
    //Plays a pre-recorded melody
    public void PlayPattern(params int[] index)
    {
        if (Pattern == null || PatternIndex >= index.Length)
        {
            Pattern = index;
            PatternIndex = 0;
        }
        if (Pattern != null && PatternIndex < index.Length)
        {
            audioSource.PlayOneShot(notes[(index[PatternIndex]) + 12]);
            PatternIndex++;
        }
    }
    //Play random note in scale
    public void PlayNote()
    {
        //Получаем индекс случайной ноты в гамме
        int indexInScale = Random.Range(0, audioResources.scales[ScaleName].Length);
        //Узнаем индекс этой ноты в массиве всех нот
        int playedNoteIndex = audioResources.scales[ScaleName][indexInScale];
        //Играем эту ноту
        audioSource.PlayOneShot(notes[playedNoteIndex]);
    }
    //Play given note
    public void PlayNote(int index)
    {
        audioSource.PlayOneShot(notes[index]);
    }
    //Play any of all notes
    void PlayAnyNote()
    {
        audioSource.PlayOneShot(notes[Random.Range(0, notes.Length)]);
    }
    //Play chord
    public void PlayNotes(params int[] index)
    {
        foreach (int i in index)
        {
            audioSource.PlayOneShot(notes[(audioResources.scales[ScaleName][i])]);
        }
    }

}

/*
 //Major scale 0 2 4 5 7 9 11
 C  C#  D   D#  E   F   F#  G   G#  A   A#  B
 0  1   2   3   4   5   6   7   8   9   10  11

C   D   E   F   G   A   B
0   1   2   3   4   5   6

scales.Add("Major", new int[] { 0, 2, 4, 5, 7, 9, 11,// 12, 14, 16, 17, 19, 23, // 24 , 26, 28, 29, 31, 35});
 */