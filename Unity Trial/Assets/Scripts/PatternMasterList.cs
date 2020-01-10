using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMasterList
{
    public Dictionary<string, int[]> CreateFluteDictionary()
    {
        Dictionary<string, int[]> fluteMasterList = new Dictionary<string, int[]> { };

        int[] fluteFiveC = { 0, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 72
        int[] fluteFiveDb = { 0, 0, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 73
        int[] fluteFiveD = { 1, 0, 1, 1, 0, 1, 1, 1, 0 };    // Pitch = 74
        int[] fluteFiveEb = { 1, 0, 1, 1, 0, 1, 1, 1, 1 };    // Pitch = 75
        int[] fluteFiveE = { 1, 1, 1, 1, 0, 1, 1, 0, 1 };    // Pitch = 76
        int[] fluteFiveF = { 1, 1, 1, 1, 0, 1, 0, 0, 1 };    // Pitch = 77
        int[] fluteFiveGb = { 1, 1, 1, 1, 0, 0, 0, 1, 1 };    // Pitch = 78
        int[] fluteFiveG = { 1, 1, 1, 1, 0, 0, 0, 0, 1 };    // Pitch = 79
        int[] fluteFiveAb = { 1, 1, 1, 1, 1, 0, 0, 0, 1 };    // Pitch = 80
        int[] fluteFiveA = { 1, 1, 1, 0, 0, 0, 0, 0, 1 };    // Pitch = 81
        int[] fluteFiveBb = { 1, 1, 0, 0, 0, 1, 0, 0, 1 };    // Pitch = 82
        int[] fluteFiveB = { 1, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 83
        fluteMasterList.Add("C5", fluteFiveC);
        fluteMasterList.Add("Db5", fluteFiveDb);
        fluteMasterList.Add("D5", fluteFiveD);
        fluteMasterList.Add("Eb5", fluteFiveEb);
        fluteMasterList.Add("E5", fluteFiveE);
        fluteMasterList.Add("F5", fluteFiveF);
        fluteMasterList.Add("Gb5", fluteFiveGb);
        fluteMasterList.Add("G5", fluteFiveG);
        fluteMasterList.Add("Ab5", fluteFiveAb);
        fluteMasterList.Add("A5", fluteFiveA);
        fluteMasterList.Add("Bb5", fluteFiveBb);
        fluteMasterList.Add("B5", fluteFiveB);

        return fluteMasterList;
    }
}
