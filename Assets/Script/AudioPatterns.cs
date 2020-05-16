using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPatterns : MonoBehaviour
{
    public Dictionary<int, int[]> Riff = new Dictionary<int, int[]>();

    private void Start()
    {
        Riff.Add(1, new int[] {0,3,5,0,3,5,0,3,5,1,1,1});
        Riff.Add(2, new int[] { 0, 9, 7, 9, 7, 5, 0, 9, 2, 3, 2, 1, 2, 13, 12, 10, 9, 7, 9, 5, 2 });

    }
}
