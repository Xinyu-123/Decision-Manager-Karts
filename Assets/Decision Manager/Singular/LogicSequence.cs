using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSequence : MonoBehaviour
{
    [SerializeField] LogicSequenceSO updateExpressions;
    [SerializeField] LogicSequenceSO fixedUpdateExpressions;
    [SerializeField] CollisionLogicSequenceSO collisionExpressions;
    [SerializeField] TriggerLogicSequenceSO triggerExpressions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateExpressions.Evaluate(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerExpressions.Evaluate(gameObject, other);
    }
}
