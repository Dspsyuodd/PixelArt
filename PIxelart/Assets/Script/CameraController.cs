using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool isMouseDown = false;
    private float mouse_sens = 0.35f;
    private float mouse_wheel_sesn = 200f;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            isMouseDown = true;

        if (Input.GetMouseButtonUp(1))
            isMouseDown = false;

        if (isMouseDown)
            transform.position -= new Vector3(Input.GetAxis("Mouse X") * mouse_sens * Mathf.Abs(transform.position.z / 5), Input.GetAxis("Mouse Y") * mouse_sens * Mathf.Abs(transform.position.z / 5), 0f);

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
            transform.position += transform.forward * Time.deltaTime * Input.GetAxis("Mouse ScrollWheel") * mouse_wheel_sesn * Mathf.Abs(transform.position.z / 2);
    }
}