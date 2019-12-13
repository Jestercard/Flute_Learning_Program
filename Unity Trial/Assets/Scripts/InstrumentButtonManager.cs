using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class InstrumentButtonManager : MonoBehaviour
{
    public GameObject buttonList;
    public int[] instrumentButtonPattern;

    private InstrumentButtonBehavior[] buttonListArray;
    public bool isPattern;
    private InputPatternChecker patternChecker;
    private PatternMasterList patternList;

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
        patternChecker = new InputPatternChecker();
        patternList = new PatternMasterList();
    }

    void Update()
    {
        //get input array pattern
        GetInstrumentButtonPattern();
        Debug.Log(buttonList);
        //get true if input array pattern matches a known pattern
        isPattern = patternChecker.IsInputAKnownPattern(instrumentButtonPattern, patternList.flutePatterns);
        Debug.Log(isPattern);
        //change states depending on isPattern
        StateSwapper(isPattern);
    }

    void GetInstrumentButtonPattern()
    {
        foreach (InstrumentButtonBehavior button in buttonListArray)
        {
            int position = 0;
            if (button.state == "release")
            {
                instrumentButtonPattern[position] = 0;
            }
            else
            {
                instrumentButtonPattern[position] = 1;
            }
            position++;
        }
    }

    void StateSwapper(bool isPattern)
    {
        if (isPattern)
        {
            foreach(InstrumentButtonBehavior button in buttonListArray)
            {
                if (button.state == "press")
                {
                    button.state = "combo";
                }
            }
        }
        else
        {
            foreach (InstrumentButtonBehavior button in buttonListArray)
            {
                if (button.state != "release")
                {
                    button.state = "press";
                }
            }
        }
    }
}
