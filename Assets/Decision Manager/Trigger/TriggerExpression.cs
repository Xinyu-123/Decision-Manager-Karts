using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// an expression of the form 
// if(condition) then response
//
[System.Serializable]
public class TriggerExpression
{
    [SerializeField]
    public TriggerCondition _condition;
    [SerializeField]
    public TriggerResponse _response;

    public bool Evaluate(GameObject _recipient, Collider _other)
    {
        if (_condition == null)
        {
            Debug.LogError("Condition was null!");
            return false;
        }

        bool result = _condition.Evaluate(_recipient, _other);
        if(result == true)
        {
            _response.Dispatch(_recipient, _other);
        }

        return result;
    }
}
