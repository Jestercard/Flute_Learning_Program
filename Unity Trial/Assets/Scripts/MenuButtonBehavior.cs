using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonBehavior : MonoBehaviour
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

    public void ChallengePlayTheNote()
    {
        Debug.Log("Challenge 1");
        SceneManager.LoadScene("Challenge_PlayTheNote");
    }
}


