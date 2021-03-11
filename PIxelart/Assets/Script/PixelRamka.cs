using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelRamka : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
