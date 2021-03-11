using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public int sizeX, sizeY;
    
    [SerializeField]
    private GameObject pixel;

    public static Color[,] pixels;

    private void Start()
    {
        pixels = new Color[sizeX, sizeY];

        for (int i = 0; i < sizeX; i++)
            for (int j = 0; j < sizeY; j++)
                pixels[i, j] = new Color(255f, 255f, 255f);
    }

    public Camera cam;

    public static Color pen_color;
    public static string paint_tool;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        
        
        if (pixels[(int)pos.x, (int)pos.y] == new Color(255f, 255f, 255f))
        {
            GameObject a = Instantiate(pixel);
            a.GetComponent<SpriteRenderer>().color = pen_color;
            pixels[(int)pos.x, (int)pos.y] = pen_color;
        }
    }

}