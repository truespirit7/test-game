using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class select_settings : MonoBehaviour
{
    public Dropdown settings;

    public AudioMixer audioMixer;
    private bool switchSound;
    public void Sound(string MixerName, int volume)
    {
        audioMixer.SetFloat(MixerName, volume);
    }
    void Start()
    {
        Screen.fullScreen = true;
        switchSound = true;
        settings.value = 5;
    }
    void Update()
    {
        // Кнопка #0 ПОМОЩЬ
        if (settings.value == 0)
        {
            Debug.Log("Тест");
            settings.value = 5;
        }

        // Кнопка #1 ЗВУК
        if (settings.value == 1 && switchSound == true)
        {
            Sound("Sound", -80);
            switchSound = false;
            settings.value = 5;
        }
        if (settings.value == 1 && switchSound == false)
        {
            Sound("Sound", 0);
            settings.value = 5;
            switchSound = true;
        }

        // Кнопка #2 МУЗЫКА
        if (settings.value == 2 && switchSound == true)
        {
            Sound("Music", -80);
            switchSound = false;
            settings.value = 5;
        }
        if (settings.value == 2 && switchSound == false)
        {
            Sound("Music", 0);
            settings.value = 5;
            switchSound = true;
        }
        // Кнопка #3 ПОЛНОЭКРАННЫЙ РЕЖИМ
        if (settings.value == 3)
        {
            if (Screen.fullScreen)
            {
                Screen.fullScreen = !Screen.fullScreen;
            }
            else
            {
                Screen.fullScreen = Screen.fullScreen;
            }
        }

        // Кнопка #5 Пустое место, используется для состояния "Никакая кнопка не нажата"

    }

}
