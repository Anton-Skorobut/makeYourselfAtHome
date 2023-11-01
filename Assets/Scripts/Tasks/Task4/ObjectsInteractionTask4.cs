using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    [SerializeField] 
    private GameObject _prefab;
    private GameObject _waffleRoot;
    [SerializeField]
    private Toaster _toaster;
    
    void Start()
    {
        _waffleRoot = GameObject.Find("WaffleRoot");
    }

    private void OnEnable()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }
    
    private void OnDisable()
    {
        _toaster.TimerIsUp -= CreateWaffle;
    }

    private void CreateWaffle()
    {
        Instantiate(_prefab, _waffleRoot.transform);
        gameObject.SetActive(false);
    }
}