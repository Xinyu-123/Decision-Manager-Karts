using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckShell : CollisionCondition
{
    public override bool Evaluate(GameObject _gameObject, Collision collision)
    {
        return collision.gameObject.tag.Equals("GreenShell");
    }

}
