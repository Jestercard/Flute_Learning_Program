using MidiJack;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButtonManager_playthenote : MonoBehaviour
{
    public GameObject buttonList;
    public int[] instrumentButtonPattern;

    private InstrumentButtonBehavior[] buttonListArray;

    private int randomValue;
    public string randomNote;
    public bool randomNoteDetector = false;
    public bool randomNoteSet = false;

    public Text displayRandomNote;
    public Text displayScore;
    private bool displayScoreBool = false;

    private int displayScoreInt = 0;

    void Start()
    {
        buttonListArray = buttonList.GetComponentsInChildren<InstrumentButtonBehavior>();
        Debug.Log("buttonListArray is built");
        instrumentButtonPattern = new int[buttonListArray.Length];
        Debug.Log($"Buttonlist is {buttonListArray.Length} in length");
    }
    void Update()
    {
        if (!randomNoteSet)
        {
            ChallengeSetup();
            randomNoteSet = true;
        }
        if (!randomNoteDetector)
        {
            GetInstrumentButtonPattern();
            randomNoteDetector = NoteAssetGroups.fluteMasterList.ElementAt(randomValue).Value.InputMatchesNote(instrumentButtonPattern);
        }
        else
        {
            if (!displayScoreBool)
            {
                StartCoroutine(WaitAndRestart());
            }
        }
    }

    void ChallengeSetup()
    {
        displayScore.text = "Score: " + displayScoreInt;
        GetRandomNote();
    }

    public void GetRandomNote()
    {
        randomValue = Random.Range(0, NoteAssetGroups.fluteMasterList.Count);
        displayRandomNote.text = "Note: " + NoteAssetGroups.fluteMasterList.ElementAt(randomValue).Value.Name;

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

    void StateSwapper()
    {
        //isPattern true turns buttons green (that are pressed) while keeping released buttons blue
        foreach (InstrumentButtonBehavior button in buttonListArray)
        {
            if (button.state == "press")
            {
                button.state = "combo";
            }
        }
    }

    private IEnumerator WaitAndRestart()
    {
        StateSwapper();
        displayRandomNote.text = "Correct!";
        displayScoreInt += 10;
        displayScore.text = "Score: " + displayScoreInt;
        displayScoreBool = true;
        yield return new WaitForSeconds(3);
        randomNoteSet = false;
        randomNoteDetector = false;
        displayScoreBool = false;
    }
}
