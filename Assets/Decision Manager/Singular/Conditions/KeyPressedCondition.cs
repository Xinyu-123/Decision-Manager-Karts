using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressedCondition : Condition
{
    [SerializeField]
    KeyCode key;
    public override bool Evaluate(GameObject _gameObject)
    {
        return Input.GetKey(key);
    }
}
