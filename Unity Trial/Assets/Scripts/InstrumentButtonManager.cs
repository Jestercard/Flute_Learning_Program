using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MidiJack;

public class InstrumentButtonManager : MonoBehaviour
{
    public GameObject buttonList;
    public int[] instrumentButtonPattern;

    private InstrumentButtonBehavior[] buttonListArray;
    public bool isPattern;

    private List<int[]> masterList = new List<int[]> { };
    public PatternMasterList patternMasterList = new PatternMasterList();

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
        masterList = patternMasterList.CreateFluteList();
        Debug.Log($"Master List Created");
    }
    void Update()
    {
        //get input array pattern
        GetInstrumentButtonPattern();
        //get true if input array pattern matches a known pattern
        isPattern = IsInputAKnownPattern(instrumentButtonPattern, masterList);
        Debug.Log(isPattern);
        //change states depending on isPattern
        StateSwapper(isPattern);
    }
    void GetInstrumentButtonPattern()
    {
        int patternPosition = 0;
        foreach (InstrumentButtonBehavior button in buttonListArray)
        {
            //velocity at 0 mean note is released, anything else is pressed
            float velocity = MidiMaster.GetKey(button.midiValue);
            if (velocity > 0)
            {
                instrumentButtonPattern[patternPosition] = 1;
                button.state = "press";
            }
            else
            {
                instrumentButtonPattern[patternPosition] = 0;
                button.state = "release";
            }
            patternPosition++;
        }
    }
    bool IsInputAKnownPattern(int[] inputPattern, List<int[]> patternList)
    {
        bool patternDetected = false;
        for(int i = 0; i < patternList.Count; i++)
        {
            patternDetected = patternList[i].SequenceEqual(inputPattern);
            if (patternDetected)
            {
                break;
            }
        }
        if (patternDetected)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void StateSwapper(bool isPattern)
    {
        //isPattern true turns buttons green (that are pressed) while keeping released buttons blue
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
        //isPattern false turns any green buttons to red
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
