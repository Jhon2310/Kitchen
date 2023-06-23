using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] _lamps;

    private void Start()
    {
        var lamps = FindObjectsOfType<Lamp>();
        _lamps = lamps;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var VARIABLE in _lamps)
            {
                VARIABLE.Interact();
            }
            
        }
    }


    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
}