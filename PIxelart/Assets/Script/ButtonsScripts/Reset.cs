using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCam;

    public void ResetCam()
    {
        mainCam.transform.position = new Vector3(0f, 0f, -10f);
    }
}
