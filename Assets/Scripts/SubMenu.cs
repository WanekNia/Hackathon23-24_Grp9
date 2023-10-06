using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public void BackToMenu()
    {
        Debug.Log("Back to main menu");
        PauseMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
