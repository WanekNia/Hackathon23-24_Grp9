using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider SliderVolume;
    public TextMeshProUGUI SliderVolumeText;
    void Start()
    {
        SliderVolumeText = GetComponent<TextMeshProUGUI>();
        ShowVolumeValue();
    }

    public void ShowVolumeValue()
    {
        string sliderMessage = "Current volume :\n" + SliderVolume.value;
        SliderVolumeText.text = sliderMessage;
    }
}
