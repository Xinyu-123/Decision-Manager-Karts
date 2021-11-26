using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointReachedResponse : Response
{
    public override void Dispatch(GameObject _gameObject)
    {
        (_gameObject.GetComponent<AIScript>() as AIScript).IncrementWayPoint();
    }


}
