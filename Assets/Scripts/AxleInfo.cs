using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxleInfo : MonoBehaviour
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
    public float motorTorque;
    public float steeringAngle;
   
}
