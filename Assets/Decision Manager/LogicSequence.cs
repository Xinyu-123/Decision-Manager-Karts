using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSequence : MonoBehaviour
{
    [SerializeField] LogicSequenceSO expressions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        expressions.Evaluate(gameObject);
    }
}
