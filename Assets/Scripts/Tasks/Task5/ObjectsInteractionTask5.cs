using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField]
    private Shelf[] _shelf;
    private void Start()
    {
        for (int i = 0; i < _shelf.Length; i++)
        {
            _shelf[i].ItemSpawned += _shelf[i].Fall;
        }
    }
    
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}