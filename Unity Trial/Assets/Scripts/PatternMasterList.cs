using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMasterList : MonoBehaviour
{
    //Flute note patterns
    public List<int[]> flutePatterns = new List<int[]> { };
    public int[] fluteFiveC = { 0, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 72
    public int[] fluteFiveDb = { 0, 0, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 73
    public int[] fluteFiveD = { 1, 0, 1, 1, 0, 1, 1, 1, 0 };    // Pitch = 74
    public int[] fluteFiveEb = { 1, 0, 1, 1, 0, 1, 1, 1, 1 };    // Pitch = 75
    public int[] fluteFiveE = { 1, 1, 1, 1, 0, 1, 1, 0, 1 };    // Pitch = 76
    public int[] fluteFiveF = { 1, 1, 1, 1, 0, 1, 0, 0, 1 };    // Pitch = 77
    public int[] fluteFiveGb = { 1, 1, 1, 1, 0, 0, 0, 1, 1 };    // Pitch = 78
    public int[] fluteFiveG = { 1, 1, 1, 1, 0, 0, 0, 0, 1 };    // Pitch = 79
    public int[] fluteFiveAb = { 1, 1, 1, 1, 1, 0, 0, 0, 1 };    // Pitch = 80
    public int[] fluteFiveA = { 1, 1, 1, 0, 0, 0, 0, 0, 1 };    // Pitch = 81
    public int[] fluteFiveBb = { 1, 1, 0, 0, 0, 1, 0, 0, 1 };    // Pitch = 82
    public int[] fluteFiveB = { 1, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 83

    private void Start()
    {
        flutePatterns.Add(fluteFiveC);
        flutePatterns.Add(fluteFiveDb);
        flutePatterns.Add(fluteFiveD);
        flutePatterns.Add(fluteFiveEb);
        flutePatterns.Add(fluteFiveE);
        flutePatterns.Add(fluteFiveF);
        flutePatterns.Add(fluteFiveGb);
        flutePatterns.Add(fluteFiveG);
        flutePatterns.Add(fluteFiveAb);
        flutePatterns.Add(fluteFiveA);
        flutePatterns.Add(fluteFiveBb);
        flutePatterns.Add(fluteFiveB);
    }
}
