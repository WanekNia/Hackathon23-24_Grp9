using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void EnterMuseum()
    {
        Debug.Log("Entering...");
        SceneManager.LoadScene(2);
    }
    public void CharacterSettings()
    {
        Debug.Log("Settings...");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
