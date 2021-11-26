using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReachedCondition : Condition
{
    float minDistSqred = 25.0f;
    public override bool Evaluate(GameObject _gameObject)
    {
        AIScript ai = _gameObject.GetComponent<AIScript>();
        Vector3 waypoint = ai.GetCurrentWaypoint().position;
        float distSqr = Mathf.Abs((waypoint - _gameObject.transform.position).sqrMagnitude);

        return distSqr < minDistSqred;
    }


}
