using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : Response
{
    [SerializeField] float forwardForce;

    public override void Dispatch(GameObject _gameObject)
    {
        CarController car = _gameObject.GetComponent<CarController>();
        if (car.heldItem == null)
            return;

        GameObject item = Instantiate(car.heldItem);
        item.transform.position = car.itemSpawnLoc.position;
        Rigidbody rb = item.GetComponent<Rigidbody>();
        rb.AddForce(_gameObject.transform.forward * forwardForce);
        //Vector3 vel = _gameObject.transform.right * forwardForce;
        //rb.velocity = vel;

        car.heldItem = null;


        Destroy(item, 10.0f);
    }
}
