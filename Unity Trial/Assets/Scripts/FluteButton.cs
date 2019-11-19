using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class FluteButton : MonoBehaviour
{
    public int midiValue;
    public GameObject fluteButtonPrefab;
    public Material buttonMaterialRelease;
    public Material buttonMaterialPressed;
    //public Material buttonComboMaterial; added in the future

    private Transform location;
    private GameObject button;
    private readonly MidiChannel midiChannel;
    public bool isPressed = false;

    public void Start()
    {
        location = GetComponent<Transform>();
        button = Instantiate<GameObject>(fluteButtonPrefab, location.position, location.rotation);
        Debug.Log($"Flute Button {midiValue} was Instantiated");
    }

    public void Update()
    {
        if (MidiMaster.GetKeyDown(midiChannel, midiValue))
        {
            ButtonIsPressed();
        }
        if (MidiMaster.GetKeyUp(midiChannel, midiValue))
        {
            ButtonIsReleased();
        }
    }
    void ButtonIsPressed()
    {
        button.GetComponent<MeshRenderer>().material = buttonMaterialPressed;
        isPressed = true;
        Debug.Log($"Flute Button {midiValue} was Pressed");
    }

    void ButtonIsReleased()
    {
        button.GetComponent<MeshRenderer>().material = buttonMaterialRelease;
        isPressed = false;
        Debug.Log($"Flute Button {midiValue} was Released");
    }
}
