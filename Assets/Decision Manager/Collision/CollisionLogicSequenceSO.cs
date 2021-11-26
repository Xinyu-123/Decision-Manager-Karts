using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scripable Objects/CollisionLogicSequenceSO", order = 2)]
public class CollisionLogicSequenceSO : ScriptableObject
{
    [SerializeField] List<CollisionExpression> expressions;

    public void Evaluate(GameObject _recipent, Collision collision)
    {
        foreach (CollisionExpression exp in expressions)
            exp.Evaluate(_recipent, collision);
    }

}
