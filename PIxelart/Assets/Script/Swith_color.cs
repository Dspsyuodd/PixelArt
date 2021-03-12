using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swith_color : MonoBehaviour
{
    
    public void Set_color()
    {
        
        print("1");
        CanvasController.pen_color = GetComponent<Image>().color;
        print("2");
    }
    
}
