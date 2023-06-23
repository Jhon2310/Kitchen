using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject _waffle;
    [SerializeField] private Transform _waffleRoot;

    private void InstantiateWaffle()
    {
        Instantiate(_waffle,_waffleRoot);
    }
    private void Start()
    {
      
        Toaster toaster = gameObject.AddComponent<Toaster>();
        toaster.TimerIsUp += InstantiateWaffle;
    }


    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}