using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerResponse : Response
{
    AxleInfo axle;
    public override void Dispatch(GameObject _gameObject)
    {
        AxleInfo axleInfo = _gameObject.GetComponent<AxleInfo>();

        //axleInfo.leftWheel.transform.Rotate(new Vector3(axleInfo.steeringAngle, 0.0f, 0.0f) * Time.fixedDeltaTime);
        //axleInfo.rightWheel.transform.Rotate(new Vector3(axleInfo.steeringAngle, 0.0f, 0.0f) * Time.fixedDeltaTime);
        axleInfo.leftWheel.steerAngle = axleInfo.steeringAngle;
        axleInfo.rightWheel.steerAngle = axleInfo.steeringAngle;
    }
}
