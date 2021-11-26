using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scripable Objects/TriggerLogicSequenceSO", order = 2)]
public class TriggerLogicSequenceSO : ScriptableObject
{
    [SerializeField] List<TriggerExpression> expressions;

    public void Evaluate(GameObject _recipent, Collider _other)
    {
        foreach (TriggerExpression exp in expressions)
            exp.Evaluate(_recipent, _other);
    }

}
