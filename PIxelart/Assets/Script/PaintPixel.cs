using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintPixel : MonoBehaviour
{
    private void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
            GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 255f);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
            GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 255f);
    }
}
