using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : TriggerResponse
{
    // If I had multiple possible items, I would make this a list
    // Then return a weighted random item in the list
    [SerializeField] GameObject item;

    public override void Dispatch(GameObject _gameObject, Collider _other)
    {
        CarController car = _gameObject.GetComponent<CarController>();

        if(car.heldItem == null)
        {
            car.heldItem = item;
        }
    }

}
