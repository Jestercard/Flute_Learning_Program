using MidiJack;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButtonManager_freeplay : MonoBehaviour
{
    public GameObject buttonList;
    public int[] instrumentButtonPattern;

    private InstrumentButtonBehavior[] buttonListArray;
    public bool isPattern;

    public Text displayText;

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
        displayText.text = "Note: ";
    }
    void Update()
    {
        //get input array pattern
        GetInstrumentButtonPattern();
        //get true if input array pattern matches a known pattern
        isPattern = IsInputAKnownPattern(instrumentButtonPattern, NoteAssetGroups.fluteMasterList);
        Debug.Log(isPattern);
        //change states depending on isPattern
        StateSwapper(isPattern);
    }
    void GetInstrumentButtonPattern()
    {
        for (int i = 0; i < buttonListArray.Length; i++)
        {
            InstrumentButtonBehavior button = buttonListArray[i];
            float velocity = MidiMaster.GetKey(button.midiValue);
            bool isPressed = velocity > 0;
            instrumentButtonPattern[i] = isPressed ? 1 : 0;
            button.state = isPressed ? "press" : "release";
        }
    }

    bool IsInputAKnownPattern(int[] inputPattern, Dictionary<int, Note> patternList)
    {
        bool patternDetected = false;
        displayText.text = "Note: ";

        foreach (var patternCombo in patternList)
        {
            var patternMatches = patternCombo.Value.InputMatchesNote(inputPattern);

            if (patternMatches)
            {
                displayText.text = "Note: " + patternCombo.Key;
                patternDetected = true;
                break;
            }
        }
        return patternDetected;
    }

    void StateSwapper(bool isPattern)
    {
        //isPattern true turns buttons green (that are pressed) while keeping released buttons blue
        if (isPattern)
        {
            foreach (InstrumentButtonBehavior button in buttonListArray)
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
