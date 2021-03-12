using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Color_set : MonoBehaviour
{
    public void Set_Color()
    {
        CanvasController.pen_color = GetComponent<Image>().color;
    }
}
