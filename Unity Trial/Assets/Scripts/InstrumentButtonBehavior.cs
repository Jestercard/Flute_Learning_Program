using UnityEngine;

public class InstrumentButtonBehavior : MonoBehaviour
{
    [Header("Individual Button Settings")]
    public int midiValue; //the value that each instance looks for from the midi device
    public string state;

    [Header("Predetermined Settings")]
    [SerializeField]
    private GameObject instrumentButtonPrefab;
    [SerializeField]
    private Material instrumentButtonMaterialRelease;
    [SerializeField]
    private Material instrumentButtonMaterialPressed;
    [SerializeField]
    private Material instrumentButtonMaterialCombo;

    private Transform location;
    private GameObject button;

    public void Start() //gets coordinates for each locate and instantiates the fluteButtonPrefab at it
    {
        location = GetComponent<Transform>();
        button = Instantiate(instrumentButtonPrefab, location.position, location.rotation);
        state = "release";
        Debug.Log($"Flute Button {midiValue} was Instantiated");
    }

    public void Update()
    {
        switch (state)
        {
            case "release": //button is blue

                button.GetComponent<MeshRenderer>().material = instrumentButtonMaterialRelease;
                break;
            case "press": //button is red
                button.GetComponent<MeshRenderer>().material = instrumentButtonMaterialPressed;
                break;
            case "combo": //button is green
                button.GetComponent<MeshRenderer>().material = instrumentButtonMaterialCombo;
                break;
        }
    }
}
