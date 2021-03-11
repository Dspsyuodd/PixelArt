using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    private void OnMouseDown()
    {
        CanvasController.paint_tool = "Eraser";
        print("GOOD");
    }
}
