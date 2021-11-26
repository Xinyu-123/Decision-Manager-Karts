using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class TriggerCondition : MonoBehaviour
{
    abstract public bool Evaluate(GameObject _gameObject, Collider _other); // generic condition to evalute
}
