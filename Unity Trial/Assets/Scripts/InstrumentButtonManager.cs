using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class InstrumentButtonManager : MonoBehaviour
{
    public GameObject buttonList;
    private InstrumentButtonBehavior[] buttonListArray;
    public int[] instrumentButtonPattern;

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
    }

    void Update()
    {
        CheckInstrumentButtonIsPressed(buttonListArray);
        //TODO make new checkpattern script
        //TODO set combo pattern if pattern is detected
    }

    private void CheckInstrumentButtonIsPressed(InstrumentButtonBehavior[] buttonListArray)
    {
        int patternPosition = 0;
        foreach(InstrumentButtonBehavior button in buttonListArray)
        {
            if (MidiMaster.GetKeyUp(button.midiValue))
            {
                button.state = "release";
                instrumentButtonPattern[patternPosition] = 0;
            }
            if (MidiMaster.GetKeyDown(button.midiValue))
            {
                button.state = "press";
                instrumentButtonPattern[patternPosition] = 1;
            }
            Debug.Log($"{button.midiValue} and {button.state} and {patternPosition}");
            patternPosition++;
        }
    }
}
