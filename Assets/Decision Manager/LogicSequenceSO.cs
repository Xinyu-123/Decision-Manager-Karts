using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scripable Objects/LogicSequenceSO", order = 1)]
public class LogicSequenceSO : ScriptableObject
{
    [SerializeField] List<Expression> expressions;

    public void Evaluate(GameObject _recipent)
    {
        foreach (Expression exp in expressions)
            exp.Evaluate(_recipent);
    }

}
