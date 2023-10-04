using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenu : MonoBehaviour
{
    public void ClickMale()
    {
        Debug.Log("Selected male character");
    }
    public void ClickFemale()
    {
        Debug.Log("Selected female character");
    }
    public void BackToMenu()
    {
        Debug.Log("Back to main menu");
        SceneManager.LoadScene(0);
    }
}
