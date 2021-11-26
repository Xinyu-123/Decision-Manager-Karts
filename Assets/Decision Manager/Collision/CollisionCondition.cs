using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CollisionCondition : MonoBehaviour
{
    abstract public bool Evaluate(GameObject _gameObject, Collision collision); // generic condition to evalute
}
