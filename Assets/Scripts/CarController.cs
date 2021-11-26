using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] List<AxleInfo> axleInfos; // the information about each individual axle
    [SerializeField] float maxMotorTorque; // maximum torque the motor can apply to wheel
    [SerializeField] float maxSteeringAngle; // maximum steer angle the wheel can have
    [SerializeField] LogicSequenceSO axleLogic;

    public void FixedUpdate()
    {
        // Move this into a decision manager
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


}
