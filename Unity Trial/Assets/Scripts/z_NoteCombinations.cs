using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteCombinations : IEnumerable
{
    private InstrumentButtonFingering[] patterns;
    public NoteCombinations(InstrumentButtonFingering[] patternArray)
    {
        patterns = new InstrumentButtonFingering[patternArray.Length];
        for(int i = 0; i < patternArray.Length; i++)
        {
            patterns[i] = patternArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }
    public NoteCombinationsEnum GetEnumerator()
    {
        return new NoteCombinationsEnum(patterns);
    }
}

public class NoteCombinationsEnum : IEnumerator
{
    private InstrumentButtonFingering[] patterns;

    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;

    public NoteCombinationsEnum(InstrumentButtonFingering[] list)
    {
        patterns = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < patterns.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public InstrumentButtonFingering Current
    {
        get
        {
            try
            {
                return patterns[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}