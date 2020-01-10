using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using MidiJack;

public class InstrumentButtonManager : MonoBehaviour
{
    public GameObject buttonList;
    public int[] instrumentButtonPattern;

    private InstrumentButtonBehavior[] buttonListArray;
    public bool isPattern;

    private Dictionary<string, int[]> masterDictionary = new Dictionary<string, int[]> { };
    public PatternMasterList patternMasterList = new PatternMasterList();

    public Text displayText;

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
        masterDictionary = patternMasterList.CreateFluteDictionary();
        Debug.Log($"Master List Created");
        displayText.text = "Note: ";
    }
    void Update()
    {
        //get input array pattern
        GetInstrumentButtonPattern();
        //get true if input array pattern matches a known pattern
        isPattern = IsInputAKnownPattern(instrumentButtonPattern, masterDictionary);
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

    bool IsInputAKnownPattern(int[] inputPattern, Dictionary<string, int[]> patternList)
    {
        bool patternDetected = false;
        foreach(var patternCombo in patternList)
        {
            patternDetected = patternCombo.Value.SequenceEqual(inputPattern);
            if (patternDetected)
            {
                displayText.text = "Note: " + patternCombo.Key;
                break;
            }
        }
        if (patternDetected)
        {
            return true;
        }
        else
        {
            displayText.text = "Note: ";
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
