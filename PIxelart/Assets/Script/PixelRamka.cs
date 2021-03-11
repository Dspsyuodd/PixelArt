using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelRamka : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.x -= pos.x % 1 - 1;
        pos.y -= pos.y % 1 - 1;
        pos.z = 0;
        transform.position = pos;
    }
}
