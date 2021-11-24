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
    private Condition _condition;
    [SerializeField]
    private Response _response;

    public bool Evaluate()
    {
        if (_condition == null)
        {
            Debug.LogError("Condition was null!");
            return false;
        }

        bool result = _condition.Evaluate();
        if(result == true)
        {
            _response.Dispatch();
        }

        return result;
    }
}
