using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    [SerializeField] List<AxleInfo> axleInfos;
    [SerializeField] Transform waypointParent;
    List<Transform> waypoints;
    [SerializeField] float maxMotorTorque; // maximum torque the motor can apply to wheel
    [SerializeField] float maxSteeringAngle; // maximum steer angle the wheel can have
    [SerializeField] LogicSequenceSO waypointIncrementer;
    [SerializeField] CollisionLogicSequenceSO itemCollision;
    Quaternion lastRotation;
    Quaternion target;
    float rotationProgress;
    int curWaypointIdx = -1;
    // Start is called before the first frame update
    void Start()
    {
        waypoints = new List<Transform>();
        // Add all the waypoints into the waypoints list
        foreach(Transform waypoint in waypointParent)
        {
            waypoints.Add(waypoint);
        }

        IncrementWayPoint();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // go towards the current waypoint
        float motor = maxMotorTorque;
        rotationProgress += maxSteeringAngle * Time.deltaTime;

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(lastRotation, target, rotationProgress);


        axleInfos[0].leftWheel.motorTorque = motor;
        axleInfos[0].rightWheel.motorTorque = motor;

        // If the waypoint has been reached, set the current waypoint to the next waypoint
        waypointIncrementer.Evaluate(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        itemCollision.Evaluate(gameObject, collision);
    }

    public Transform GetCurrentWaypoint()
    {
        return waypoints[curWaypointIdx];
    }

    public void IncrementWayPoint()
    {
        curWaypointIdx = (curWaypointIdx + 1) % waypoints.Count;

        lastRotation = transform.rotation;
        rotationProgress = 0.0f;
        target = Quaternion.LookRotation(waypoints[curWaypointIdx].position - transform.position);

    }
    public void ResetVelocity()
    {
        // Reset all velocity to 0
        foreach (AxleInfo axleInfo in axleInfos)
        {
            axleInfo.leftWheel.attachedRigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            axleInfo.rightWheel.attachedRigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }

    }
}
