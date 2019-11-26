using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class InstrumentButtonBehavior : MonoBehaviour
{
    public int midiValue;
    public GameObject fluteButtonPrefab;
    public Material buttonMaterialRelease;
    public Material buttonMaterialPressed;
    public Material buttonMaterialCombo;
    public bool isPressed = false;
    private Transform location;
    private GameObject button;

    public void Start()
    {
        location = GetComponent<Transform>();
        button = Instantiate<GameObject>(fluteButtonPrefab, location.position, location.rotation);
        Debug.Log($"Flute Button {midiValue} was Instantiated");
    }
    public void ButtonIsPressed()
    {
        button.GetComponent<MeshRenderer>().material = buttonMaterialPressed;
        isPressed = true;
    }

    public void ButtonIsReleased()
    {
        button.GetComponent<MeshRenderer>().material = buttonMaterialRelease;
        isPressed = false;
    }

    public void ButtonIsCombo()
    {
        button.GetComponent<MeshRenderer>().material = buttonMaterialCombo;
        isPressed = true;
    }
}
