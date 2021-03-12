using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public static int sizeX = 10, sizeY = 10;

    [SerializeField]
    private GameObject pixel;
    [SerializeField]
    private GameObject CanvasStart;

    public static Color[,] pixels;


    private void Start()
    {
        GameObject holst = Instantiate(CanvasStart, new Vector3(sizeX / 2 - 0.5f * (sizeX % 2 == 0 ? 1 : 0), sizeY / 2 - 0.5f * (sizeY % 2 == 0 ? 1 : 0), 0f), Quaternion.identity);
        holst.transform.localScale = new Vector2(sizeX, sizeY);

        pixels = new Color[sizeX, sizeY];
        
        for (int i = 0; i < sizeX; i++)
            for (int j = 0; j < sizeY; j++)
                pixels[i, j] = new Color(1f, 1f, 1f);
    }
    public Camera cam;

    public static Color pen_color = new Color(1f, 0.5f, 0.7f);
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
                if (pixels[(int)pos.x, (int)pos.y] == new Color(1f, 1f, 1f))
                {
                    GameObject a = Instantiate(pixel, pos, Quaternion.identity);
                    a.GetComponent<SpriteRenderer>().color = pen_color;
                    pixels[(int)pos.x, (int)pos.y] = pen_color;
                }
            }
        }
    }

    public void Save()
    {
        string path = Application.streamingAssetsPath + @"\" + "pixelart.txt";

        StreamWriter infile = new StreamWriter(path);

        infile.WriteLine(sizeX.ToString() + " " + sizeY.ToString());

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                infile.WriteLine(pixels[i,j].r.ToString() + " " + pixels[i, j].g.ToString() + " " + pixels[i, j].b.ToString());
            }
        }
        infile.Close();
    }

    public void Load()
    {
        var a = Resources.Load<TextAsset>("pixelart");
        string[] load = a.text.Split();

        sizeX = int.Parse(load[0]);
        sizeY = int.Parse(load[1]);

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                pixels[i, j].r = float.Parse(load[i * (sizeY + 3) + j]);
                pixels[i, j].g = float.Parse(load[i * (sizeY + 3) + j + 1]);
                pixels[i, j].b = float.Parse(load[i * (sizeY + 3) + j + 2]);
            }
        }

    }
}