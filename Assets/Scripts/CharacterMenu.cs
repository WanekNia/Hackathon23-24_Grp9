using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenu : SubMenu
{
    public void ClickMale()
    {
        Debug.Log("Selected male character");
    }
    public void ClickFemale()
    {
        Debug.Log("Selected female character");
    }
}
