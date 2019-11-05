using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void MainMenuButton()
    {
        Debug.Log("Main Menu Button");
        SceneManager.LoadScene("MainMenu");
    }

    public void FreePlayButton()
    {
        Debug.Log("FreePlay Button");
        SceneManager.LoadScene("FreePlay");
    }

    public void ChallengeButton()
    {
        Debug.Log("Challenge Button");
        SceneManager.LoadScene("Challenge");
    }

    public void OptionsButton()
    {
        Debug.Log("Options Button");
        SceneManager.LoadScene("Options");
    }
}


