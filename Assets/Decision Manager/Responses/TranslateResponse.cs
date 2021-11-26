using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateResponse : Response
{
    [SerializeField]
    private Vector3 displacement;
    public override void Dispatch(GameObject _gameObject)
    {
        _gameObject.transform.Translate(displacement);
    }

}
