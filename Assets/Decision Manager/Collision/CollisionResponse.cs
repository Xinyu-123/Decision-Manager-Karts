using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CollisionResponse : MonoBehaviour
{
    abstract public void Dispatch(GameObject _gameObject, Collision collision);
}
