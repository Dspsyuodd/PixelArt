using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelRamka : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = 0;
        transform.position = pos;
    }
}
