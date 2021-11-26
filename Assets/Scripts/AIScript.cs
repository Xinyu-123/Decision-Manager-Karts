using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    [SerializeField] List<AxleInfo> axleInfos;
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float maxMotorTorque; // maximum torque the motor can apply to wheel
    [SerializeField] float maxSteeringAngle; // maximum steer angle the wheel can have
    [SerializeField] LogicSequenceSO waypointIncrementer;

    int curWaypointIdx = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // go towards the current waypoint
        float motor = maxMotorTorque;


        // Rotate towards the waypoint
        transform.LookAt(waypoints[curWaypointIdx]);
        axleInfos[0].leftWheel.motorTorque = motor;
        axleInfos[0].rightWheel.motorTorque = motor;

        // If the waypoint has been reached, set the current waypoint to the next waypoint
        waypointIncrementer.Evaluate(gameObject);
    }


    public Transform GetCurrentWaypoint()
    {
        return waypoints[curWaypointIdx];
    }

    public void IncrementWayPoint()
    {
        curWaypointIdx = (curWaypointIdx + 1) & waypoints.Count;
    }
}
