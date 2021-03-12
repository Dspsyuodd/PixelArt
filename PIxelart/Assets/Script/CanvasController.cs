using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public static int sizeX, sizeY;

    [SerializeField]
    private GameObject pixel;
    [SerializeField]
    private GameObject CanvasStart;

    public static Color[,] pixels;


    private void Start()
    {
        print(sizeX);
        print(sizeY);
        GameObject holst = Instantiate(CanvasStart, new Vector3(sizeX / 2 - 0.5f * (sizeX % 2 == 0 ? 1 : 0), sizeY / 2 - 0.5f * (sizeY % 2 == 0 ? 1 : 0), 0f), Quaternion.identity);
        holst.transform.localScale = new Vector2(sizeX, sizeY);

        pixels = new Color[sizeX, sizeY];
        
        for (int i = 0; i < sizeX; i++)
            for (int j = 0; j < sizeY; j++)
                pixels[i, j] = new Color(255f, 255f, 255f);
    }

    public Camera cam;

    public static Color pen_color = new Color(255f, 255f, 0f);
    public static string paint_tool = "Pen";

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            pos.z = 0f;

            if (pen_color != new Color(255f, 255f, 255f) && pos.x >= 0 && pos.x < sizeX && pos.y >= 0 && pos.y < sizeY && paint_tool == "Pen")
            {
                if (pixels[(int)pos.x, (int)pos.y] == new Color(255f, 255f, 255f))
                {
                    GameObject a = Instantiate(pixel, pos, Quaternion.identity);
                    a.GetComponent<SpriteRenderer>().color = pen_color;
                    pixels[(int)pos.x, (int)pos.y] = pen_color;
                }
            }
        }
    }
}