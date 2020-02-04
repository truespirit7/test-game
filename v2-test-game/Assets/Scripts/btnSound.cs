using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class btnSound : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip ClickFX;
    private GameObject[] Btn;   
    private void Start()
    {
        Btn = GameObject.FindGameObjectsWithTag("Buttons"); // ищем все объекты с тегом "Кнопки"

        ClickSound();
    }
    private void FixedUpdate()
    {
        if (GameObject.FindGameObjectsWithTag("Buttons").Length != Btn.Length) 
        {
            Btn = GameObject.FindGameObjectsWithTag("Buttons"); // ищем все объекты с тегом "Кнопки"
            ClickSound();
        }

    }
    public void ClickSound()
    {
        
        for (int i = 0; i <Btn.Length; i++) 
        {
            EventTrigger click = Btn[i].AddComponent<EventTrigger>(); // добавляем обработчик события "клик" всем кнопкам
            var pointerDown = new EventTrigger.Entry(); // создаем новое событие
            pointerDown.eventID = EventTriggerType.PointerDown; // делаем это событие обработчиком нажатия на кнопку
            pointerDown.callback.AddListener((e) => mySound.PlayOneShot(ClickFX)); // если событие происходит, то проигрывается звук ClickFX
            click.triggers.Add(pointerDown); // добавляем событие в обработчик собыйтий (click) наших кнопок
            Btn = GameObject.FindGameObjectsWithTag("Buttons"); // ищем все объекты с тегом "Кнопки"
        }
    }

}
