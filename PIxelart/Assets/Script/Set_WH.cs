using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_WH : MonoBehaviour
{
    public static int Height;
    public static int Width;
    public InputField Wi;
    public InputField He;

    public void Set_value()
    {
        Height = int.Parse(He.text.ToString());
        Width = int.Parse(Wi.text.ToString());
        print(He.text.ToString());
        print(Wi.text.ToString());
    } 
}
