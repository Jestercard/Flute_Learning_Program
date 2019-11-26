using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class InstrumentButtonManager : MonoBehaviour
{
    public GameObject button0;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;

    public int[] actualButtonPattern;
    private InstrumentButtonBehavior instrumentButtonBehavior;

    void Start()
    {
        actualButtonPattern = new int[9]; //TODO adjust to have as many active buttons as needed
    }

    void Update()
    {
        CheckInstrumentButtonIsPressed(button0, 0);
        CheckInstrumentButtonIsPressed(button1, 1);
        CheckInstrumentButtonIsPressed(button2, 2);
        CheckInstrumentButtonIsPressed(button3, 3);
        CheckInstrumentButtonIsPressed(button4, 4);
        CheckInstrumentButtonIsPressed(button5, 5);
        CheckInstrumentButtonIsPressed(button6, 6);
        CheckInstrumentButtonIsPressed(button7, 7);
        CheckInstrumentButtonIsPressed(button8, 8);
        
        //TODO make new checkpattern script

    }

    private void CheckInstrumentButtonIsPressed(GameObject button, int a)
    {
        if (MidiMaster.GetKeyDown(MidiChannel.Ch1, button.GetComponent<InstrumentButtonBehavior>().midiValue))
        {
            button.GetComponent<InstrumentButtonBehavior>().ButtonIsPressed();
            Debug.Log($"MIDI value {button.GetComponent<InstrumentButtonBehavior>().midiValue} pressed");
        }
        else if (MidiMaster.GetKeyUp(MidiChannel.Ch1, button.GetComponent<InstrumentButtonBehavior>().midiValue))
        {
            button.GetComponent<InstrumentButtonBehavior>().ButtonIsReleased();
            Debug.Log($"MIDI value {button.GetComponent<InstrumentButtonBehavior>().midiValue} released");
        }

        if (button.GetComponent<InstrumentButtonBehavior>().isPressed)
        {
            actualButtonPattern[a] = 1;
        }
        else
        {
            actualButtonPattern[a] = 0;
        }
    }
}
