using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] List<AxleInfo> axleInfos; // the information about each individual axle
    [SerializeField] float maxMotorTorque; // maximum torque the motor can apply to wheel
    [SerializeField] float maxSteeringAngle; // maximum steer angle the wheel can have
    [SerializeField] LogicSequenceSO axleLogic;
    [SerializeField] LogicSequenceSO fireItemLogic;
    [SerializeField] CollisionLogicSequenceSO collisionLogic;
    [SerializeField] TriggerLogicSequenceSO triggerLogic;

    public Transform itemSpawnLoc;

    public GameObject heldItem;

    private void Update()
    {
        fireItemLogic.Evaluate(gameObject);
    }


    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            axleInfo.motorTorque = motor;
            axleInfo.steeringAngle = steering;
            axleLogic.Evaluate(axleInfo.gameObject);
            axleLogic.Evaluate(axleInfo.gameObject);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionLogic.Evaluate(gameObject, collision);
    }

    private void OnTriggerStay(Collider other)
    {
        triggerLogic.Evaluate(gameObject, other);
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
