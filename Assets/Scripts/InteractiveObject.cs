using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    private ControlDialog dialoges;
    public string titleStart;
    private bool onMouser;
    // Start is called before the first frame update
    void Start()
    {
        dialoges = FindObjectOfType<ControlDialog>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseInteraction();
    }
    void OnMouseEnter()
    {
        if (!dialoges.onChatting)
        {
            CanInter();
        }
        onMouser = true;
    }
    void MouseInteraction()
    {
        if (Input.GetMouseButtonDown(0) && (onMouser || dialoges.onChatting))
        {
            if (dialoges.onChatting)
            {
                CantInter();
            }
            else if (!dialoges.onChatting && onMouser)
            {
                CanInter();
                dialoges.StartChat(titleStart);
            }
        }
    }
    void OnMouseExit()
    {
        CantInter();
        onMouser = false;
    }
    void CanInter()
    {
        Vector2 scaler;
        scaler.x = 1.2f;
        scaler.y = 1.2f;
        transform.localScale = scaler;
    }
    void CantInter()
    {
        Vector2 scaler;
        scaler.x = 1;
        scaler.y = 1;
        transform.localScale = scaler;
    }
}
