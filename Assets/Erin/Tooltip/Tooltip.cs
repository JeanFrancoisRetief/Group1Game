using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public string message;

    public void OnMouseEnter()
    {
        TooltipManager.instance.SetAndShowToolTip(message);
    }

    public void OnMouseExit()
    {
        TooltipManager.instance.HideToolTip(); 
    }
}
