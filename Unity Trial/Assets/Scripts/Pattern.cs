using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    public GameObject fluteButtons;

    private int[] fluteFiveC  = { 0, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 72
    private int[] fluteFiveDb = { 0, 0, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 73
    private int[] fluteFiveD  = { 1, 0, 1, 1, 0, 1, 1, 1, 0 };    // Pitch = 74
    private int[] fluteFiveEb = { 1, 0, 1, 1, 0, 1, 1, 1, 1 };    // Pitch = 75
    private int[] fluteFiveE  = { 1, 1, 1, 1, 0, 1, 1, 0, 1 };    // Pitch = 76
    private int[] fluteFiveF  = { 1, 1, 1, 1, 0, 1, 0, 0, 1 };    // Pitch = 77
    private int[] fluteFiveGb = { 1, 1, 1, 1, 0, 0, 0, 1, 1 };    // Pitch = 78
    private int[] fluteFiveG  = { 1, 1, 1, 1, 0, 0, 0, 0, 1 };    // Pitch = 79
    private int[] fluteFiveAb = { 1, 1, 1, 1, 1, 0, 0, 0, 1 };    // Pitch = 80
    private int[] fluteFiveA  = { 1, 1, 1, 0, 0, 0, 0, 0, 1 };    // Pitch = 81
    private int[] fluteFiveBb = { 1, 1, 0, 0, 0, 1, 0, 0, 1 };    // Pitch = 82
    private int[] fluteFiveB  = { 1, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 83
    private int[] fluteButtonPattern = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        
    }

    void Update()
    {

        foreach(int i in fluteButtonPattern)
        {

        }

    }

    private void GetFluteButtonPattern()
    {

        {

        }
    }
}
