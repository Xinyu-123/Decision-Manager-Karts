using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugResponse : Response
{
    [SerializeField]
    private string msg;
    public override void Dispatch()
    {
        Debug.Log(msg);
    }
}
