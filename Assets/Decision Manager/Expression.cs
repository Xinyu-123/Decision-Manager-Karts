using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// an expression of the form 
// if(condition) then response
//
[System.Serializable]
public class Expression
{
    [SerializeField]
    public Condition _condition;
    [SerializeField]
    public Response _response;

    public bool Evaluate(GameObject _recipient)
    {
        if (_condition == null)
        {
            Debug.LogError("Condition was null!");
            return false;
        }

        bool result = _condition.Evaluate(_recipient);
        if(result == true)
        {
            _response.Dispatch(_recipient);
        }

        return result;
    }
}
