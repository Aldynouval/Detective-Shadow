using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumemanager : MonoBehaviour
{
    Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }
    }

    public void changevolume()
    {
        AudioListener.volume = slider.value;
        save();
    }

    public void load()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume", slider.value);
    }
}
