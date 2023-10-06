using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CharacterSettingsMenu;

    public void EnterMuseum()
    {
        Debug.Log("Entering...");
        SceneManager.LoadScene("Main Scene");
    }
    public void CharacterSettings()
    {
        Debug.Log("Settings...");
        CharacterSettingsMenu.SetActive(true);
        gameObject.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
