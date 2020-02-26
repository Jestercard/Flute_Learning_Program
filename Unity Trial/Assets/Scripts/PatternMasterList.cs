using System.Collections.Generic;

public class PatternMasterList
{

    private static int[] fluteFiveC = { 0, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 72
    private static int[] fluteFiveDb = { 0, 0, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 73
    private static int[] fluteFiveD = { 1, 0, 1, 1, 0, 1, 1, 1, 0 };    // Pitch = 74
    private static int[] fluteFiveEb = { 1, 0, 1, 1, 0, 1, 1, 1, 1 };    // Pitch = 75
    private static int[] fluteFiveE = { 1, 1, 1, 1, 0, 1, 1, 0, 1 };    // Pitch = 76
    private static int[] fluteFiveF = { 1, 1, 1, 1, 0, 1, 0, 0, 1 };    // Pitch = 77
    private static int[] fluteFiveGb = { 1, 1, 1, 1, 0, 0, 0, 1, 1 };    // Pitch = 78
    private static int[] fluteFiveG = { 1, 1, 1, 1, 0, 0, 0, 0, 1 };    // Pitch = 79
    private static int[] fluteFiveAb = { 1, 1, 1, 1, 1, 0, 0, 0, 1 };    // Pitch = 80
    private static int[] fluteFiveA = { 1, 1, 1, 0, 0, 0, 0, 0, 1 };    // Pitch = 81
    private static int[] fluteFiveBb = { 1, 1, 0, 0, 0, 1, 0, 0, 1 };    // Pitch = 82
    private static int[] fluteFiveB = { 1, 1, 0, 0, 0, 0, 0, 0, 1 };    // Pitch = 83

    public static Dictionary<string, int[]> fluteMasterList = new Dictionary<string, int[]> {
        {"C5", fluteFiveC },
        {"Db5", fluteFiveDb},
        {"D5", fluteFiveD},
        {"Eb5", fluteFiveEb},
        {"E5", fluteFiveE},
        {"F5", fluteFiveF},
        {"Gb5", fluteFiveGb},
        {"G5", fluteFiveG},
        {"Ab5", fluteFiveAb},
        {"A5", fluteFiveA},
        {"Bb5", fluteFiveBb},
        {"B5", fluteFiveB}
    };
}
