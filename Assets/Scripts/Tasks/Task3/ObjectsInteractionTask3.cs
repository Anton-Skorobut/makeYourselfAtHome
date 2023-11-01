using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private GameObject _kitchen;
    private Lamp[] _lamps;

    private void Start()
    {
        _kitchen = GameObject.Find("Kitchen");
        _lamps = _kitchen.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            foreach (var lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
}