using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    private void OnMouseDown()
    {
        CanvasController.paint_tool = "Pen";
        print("GOOD");
    }
}
