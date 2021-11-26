using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Image item;
    [SerializeField] Texture2D greenShell;
    [SerializeField] CarController car;

    Sprite greenShellSprite;
    // Start is called before the first frame update
    void Start()
    {
        greenShellSprite = Sprite.Create(greenShell, new Rect(0.0f, 0.0f, greenShell.width, greenShell.height), new Vector2(0.5f, 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if(car.heldItem != null)
        {
            item.sprite = greenShellSprite;
        }
        else
        {
            item.sprite = null;
        }
    }
}
