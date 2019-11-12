using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class FluteButton : MonoBehaviour
{
    public int midiValue;
    public GameObject ButtonReleasedPrefab;
    public GameObject ButtonPressedPrefab;

    private Transform location;
    private GameObject buttonReleased;
    private GameObject buttonPressed;
    private MidiChannel midiChannel;


    public void Start()
    {
        location = GetComponent<Transform>();
        buttonReleased = (GameObject)Instantiate(ButtonReleasedPrefab, location.position, location.rotation);
        Debug.Log($"Flute Button {midiValue} was Instantiated");
    }

    public void Update()
    {
        if (MidiMaster.GetKeyDown(midiChannel, midiValue))
        {
            ButtonIsPressed();
        }
        else if (MidiMaster.GetKeyUp(midiChannel, midiValue))
        {
            ButtonIsReleased();
        }
    }
    public void ButtonIsPressed()
    {
        Destroy(buttonReleased);
        buttonPressed = (GameObject)Instantiate(ButtonPressedPrefab, location.position, location.rotation);
        Debug.Log($"Flute Button {midiValue} was Pressed");
    }

    public void ButtonIsReleased()
    {
        Destroy(buttonPressed);
        buttonReleased = (GameObject)Instantiate(ButtonReleasedPrefab, location.position, location.rotation);
        Debug.Log($"Flute Button {midiValue} was Released");
    }
}
