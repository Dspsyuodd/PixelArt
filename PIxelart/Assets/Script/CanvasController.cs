using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    private int sizeX, sizeY;

    public GameObject pixel;

    private void Start()
    {
        GameObject[,] pixels;
        pixels = new GameObject[sizeX, sizeY];

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                pixels[i,j] = Instantiate(pixel, new Vector3(i, j, 0f), Quaternion.identity);
            }
        }
    }
}
