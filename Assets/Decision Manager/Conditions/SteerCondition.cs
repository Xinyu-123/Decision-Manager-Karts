using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerCondition : Condition
{
    public override bool Evaluate(GameObject _gameObject)
    {
        return (_gameObject.GetComponent<AxleInfo>() as AxleInfo).steering;
    }
}
