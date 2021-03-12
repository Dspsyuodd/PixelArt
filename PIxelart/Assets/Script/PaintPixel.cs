using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintPixel : MonoBehaviour
{
    private void OnMouseEnter()
    {
        DrawPixel();
    }

    private void OnMouseDown()
    {
        DrawPixel();
    }

    private void DrawPixel()
    {
        if (Input.GetMouseButton(0))
        {
            if (CanvasController.paint_tool == "Pen")
            {
                GetComponent<SpriteRenderer>().color = CanvasController.pen_color;
                CanvasController.pixels[(int)gameObject.transform.position.x, (int)gameObject.transform.position.y] = CanvasController.pen_color;
            }
            else if (CanvasController.paint_tool == "Eraser")
            {
                Destroy(gameObject);
                CanvasController.pixels[(int)gameObject.transform.position.x, (int)gameObject.transform.position.y] = new Color(1f, 1f, 1f);
            }
        }
    }
}
