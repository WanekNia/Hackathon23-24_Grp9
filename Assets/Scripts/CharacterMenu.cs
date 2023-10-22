using UnityEngine;

public class CharacterMenu : SubMenu
{
    [SerializeField] private GameObject male;
    [SerializeField] private GameObject female;
    
    public void ClickMale()
    {
        StaticData.PlayerGender = male;
        Debug.Log("Selected male character");
        gameObject.SetActive(false);
        PauseMenu.SetActive(true);
    }
    public void ClickFemale()
    {
        StaticData.PlayerGender = female;
        Debug.Log("Selected female character");
        gameObject.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
