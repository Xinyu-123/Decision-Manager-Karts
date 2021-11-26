using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHitResponse : CollisionResponse
{
    public override void Dispatch(GameObject _gameObject, Collision collision)
    {
        // I should have used polymorphism here but no time
        CarController car = _gameObject.GetComponent<CarController>();

        if(car != null)
            car.ResetVelocity();

        AIScript ai = _gameObject.GetComponent<AIScript>();

        if (ai != null)
            ai.ResetVelocity();

        // Break the shell
        Destroy(collision.gameObject);
    }
}
