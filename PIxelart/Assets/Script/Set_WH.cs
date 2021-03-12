using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_WH : MonoBehaviour
{
    
    public InputField Wi;
    public InputField He;

    public void Set_value()
    {
        CanvasController.sizeY = int.Parse(He.text.ToString());
        CanvasController.sizeX = int.Parse(Wi.text.ToString());
        //print(He.text.ToString());
        //print(Wi.text.ToString());
    } 
}
