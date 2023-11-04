using System;
using UnityEditor;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    [SerializeField]
    private Shelf Shelf1;
    [SerializeField]
    private Shelf Shelf2;
    

    private void Start()
    {
        Shelf1.ItemSpawned += OnItemSpawned;
        Shelf2.ItemSpawned += OnItemSpawned;
    }

    private void OnDisable()
    {
        Shelf1.ItemSpawned -= OnItemSpawned;
        Shelf2.ItemSpawned -= OnItemSpawned;
    }
    
    private void OnItemSpawned()
    {
        if (Shelf1.ItemsCount > 3)
        {
            Shelf1.Fall();
        }

        if (Shelf2.ItemsCount > 3)
        {
            Shelf2.Fall();
        }
    }
}
