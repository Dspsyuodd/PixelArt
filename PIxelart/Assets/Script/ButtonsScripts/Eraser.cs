using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    public void ToolChange()
    {
        CanvasController.paint_tool = "Eraser";
    }
}
