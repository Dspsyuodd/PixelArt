using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    public void ToolChange()
    {
        CanvasController.paint_tool = "Pen";
    }
}
