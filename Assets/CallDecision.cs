using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallDecision : MonoBehaviour
{
    [SerializeField]
    LogicSequence logic;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Expression expr in logic.expressions)
            expr.Evaluate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
