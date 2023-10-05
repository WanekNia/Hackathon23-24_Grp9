    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PauseButton;
    public GameObject CharacterSettingsMenu;
    public GameObject PauseMenu;
    public GameObject SoundSettingsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
        PauseMenu.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        PauseMenu.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CharacterSettings()
    {
        Debug.Log("Settings...");
        CharacterSettingsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void SoundSettings()
    {
        Debug.Log("Settings...");
        SoundSettingsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
