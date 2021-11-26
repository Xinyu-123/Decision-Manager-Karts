using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Condition : MonoBehaviour
{
    abstract public bool Evaluate(GameObject _gameObject); // generic condition to evalute
}
