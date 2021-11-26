using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// an expression of the form 
// if(condition) then response
//
[System.Serializable]
public class CollisionExpression
{
    [SerializeField]
    public CollisionCondition _condition;
    [SerializeField]
    public CollisionResponse _response;

    public bool Evaluate(GameObject _recipient, Collision collision)
    {
        if (_condition == null)
        {
            Debug.LogError("Condition was null!");
            return false;
        }

        bool result = _condition.Evaluate(_recipient, collision);
        if(result == true)
        {
            _response.Dispatch(_recipient, collision);
        }

        return result;
    }
}
