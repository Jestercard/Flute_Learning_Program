using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentButtonFingering : MonoBehaviour
{
    public int[] pattern;

    public InstrumentButtonFingering(int[] pattern)
    {
        this.pattern = pattern;
    }
}