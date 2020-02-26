using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAssetGroups
{
    private static Note fluteFiveC = new Note("C5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 1 });
    private static Note fluteFiveDb = new Note("Db5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 });
    private static Note fluteFiveD = new Note("D5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 0 });
    private static Note fluteFiveEb = new Note("Eb5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1 });
    private static Note fluteFiveE = new Note("E5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 1, 0, 1, 1, 0, 1 });
    private static Note fluteFiveF = new Note("F5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 1 });
    private static Note fluteFiveGb = new Note("Gb5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 1, 0, 0, 0, 1, 1 });
    private static Note fluteFiveG = new Note("G5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 1 });
    private static Note fluteFiveAb = new Note("Ab5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 1 });
    private static Note fluteFiveA = new Note("A5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 1, 0, 0, 0, 0, 0, 1 });
    private static Note fluteFiveBb = new Note("Bb5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 0, 0, 0, 1, 0, 0, 1 });
    private static Note fluteFiveB = new Note("B5", "Assets/NotePictures/", "Assets/AudioFiles/", new int[] { 1, 1, 0, 0, 0, 0, 0, 0, 1 });

    public static Dictionary<int, Note> fluteMasterList = new Dictionary<int, Note> {
        {1, fluteFiveC },
        {2, fluteFiveDb},
        {3, fluteFiveD},
        {4, fluteFiveEb},
        {5, fluteFiveE},
        {6, fluteFiveF},
        {7, fluteFiveGb},
        {8, fluteFiveG},
        {9, fluteFiveAb},
        {10, fluteFiveA},
        {11, fluteFiveBb},
        {12, fluteFiveB}
    };
}
