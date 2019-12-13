using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPatternChecker : MonoBehaviour
{
    private bool patternMatch;
    public bool IsInputAKnownPattern(int[] inputPattern, List<int[]> patternList)
    {
        if (patternList.Contains(inputPattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
