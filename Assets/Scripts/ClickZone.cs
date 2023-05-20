using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZone : MonoBehaviour
{
    public ControlDialog dialogis;
    private bool onToMouse;
    private void OnMouseEnter()
    {
        onToMouse = true;
    }
    private void OnMouseDown()
    {
        if(onToMouse)
        dialogis.Clicker();
    }
}
