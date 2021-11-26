using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorResponse : Response
{
    public override void Dispatch(GameObject _gameObject)
    {
        AxleInfo axleInfo = _gameObject.GetComponent<AxleInfo>();
        axleInfo.leftWheel.transform.Rotate(new Vector3(0.0f, -axleInfo.motorTorque, 0.0f) * Time.fixedDeltaTime);
        axleInfo.rightWheel.transform.Rotate(new Vector3(0.0f, -axleInfo.motorTorque, 0.0f) * Time.fixedDeltaTime);
        axleInfo.leftWheel.motorTorque = axleInfo.motorTorque;
        axleInfo.rightWheel.motorTorque = axleInfo.motorTorque;
    }


}
