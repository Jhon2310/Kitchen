using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _prifab;
    [SerializeField]
    private Transform _lampRoot;
    private void Awake()
    {
        Instantiate(_prifab, _lampRoot);
    }
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
}