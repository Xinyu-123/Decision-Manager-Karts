using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItem : TriggerCondition
{
    
    public override bool Evaluate(GameObject _gameObject, Collider _other)
    {
        return _other.tag.Equals("ItemBox");
    }

}
