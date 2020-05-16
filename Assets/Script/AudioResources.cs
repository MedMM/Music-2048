using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioResources : MonoBehaviour
{
    public Dictionary<int, int[]> Riff = new Dictionary<int, int[]>();
    public Dictionary<string, int[]> scales = new Dictionary<string, int[]>(2);
    public Dictionary<string, int[]> chords = new Dictionary<string, int[]>(2);

        /*
         * 
         * 36 notes
         * min index: 0    Max index:35
    C  C#  D   D#  E   F   F#  G   G#  A   A#  B
    0  1   2   3   4   5   6   7   8   9   10  11 

    0 3  5 7 10
    C D# F G A#
        */

    void Start()
    {
        // Smoke on the water
        Riff.Add(1, new int[] { 0, 3, 5, 0, 3, 6, 5, 0, 3, 5, 3, 0 });
        //Anthem of Ukraine
        Riff.Add(2, new int[] {});
        //Back to the 80'th
        Riff.Add(3, new int[] { 4, 8, 11, 15, 4, 8, 11, 15, 4, 8, 11, 13, 4, 8, 9, 8});

        //2 6 minor pentatonic
        //4 7
        //scales.Add("Major", new int[]       { 0, 2, 4, 5, 7, 9, 11, /**/12, 14, 16, 17, 19, 21, 23,/**/24, 26, 28, 29, 31, 33, 35 });
        //scales.Add("Minor", new int[]       { 0, 2, 3, 5, 7, 8, 10, /**/12, 14, 15, 17, 19, 20, 22,/**/24, 26, 27, 29, 31, 32, 34 });
        //scales.Add("Major", new int[]       { 0, 2, 4, 5, 9,  /**/12, 14, 16, 17,  21,/*24, 26, 28*/});
        //scales.Add("Minor", new int[]       { 0,3, 5, 7, 10, /**/12, 15, 17, 19,  22,/*24, 27, 29*/});

        scales.Add("Major", new int[] {/* 0, 2, 4, */7, 11, 12, 14, 16, 19, 23,/**/24, 26, 28, 31, 35 });
        scales.Add("Minor", new int[] { /*0, 3, 5,*/ 7,10,/**/ 12, 15, 17, 19, 22,/**/24,  27, 29, 31, 34 });
        scales.Add("Dorian", new int[]      { 0, 2, 3, 5, 7, 9, 10, /**/12, 14, 15, 17, 19, 21, 22,/**/24, 26, 27, 29, 31, 33, 34 });
        scales.Add("Phrygrian", new int[]   { 0, 1, 3, 5, 7, 9, 10, /**/12, 13, 15, 17, 19, 21, 22,/**/24, 25, 27, 29, 31, 33, 34 });
        scales.Add("Lydian", new int[]      { 0, 2, 4, 6, 7, 9, 11, /**/12, 14, 16, 18, 19, 21, 23,/**/24, 26, 28, 30, 31, 33, 35 });
        scales.Add("Mixolydian", new int[]  { 0, 2, 4, 5, 7, 9, 10, /**/12, 14, 16, 17, 19, 21, 22,/**/24, 26, 28, 29, 31, 33, 34 });
        scales.Add("Locrian", new int[]     { 0, 1, 3, 5, 6, 8, 10, /**/12, 13, 15, 17, 18, 20, 22,/**/24, 25, 27, 29, 30, 32, 34 });
        scales.Add("All Notes", new int[]   {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35 });

        chords.Add("C", new int[] { 0, 2, 4 });
        chords.Add("G", new int[] { 4, 6, 1 });
        chords.Add("F", new int[] { 0, 3, 5 });
        chords.Add("Dm", new int[] { 1, 3, 5 });
        chords.Add("Am", new int[] { 5, 0, 2 });
        chords.Add("Em", new int[] { 2, 4, 6 });
    }
}
