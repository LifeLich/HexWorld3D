using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitelGenerator : MonoBehaviour
{
    public TileType[] TileTypes;
    public int[,] Tiles;
    public int SizeX;
    public int SideY;
    // Use this for initialization
    void Start () {
        //this is just data
        //make Tiles
        Tiles = new int[SizeX,SideY];
        //setup Titels
        for (int x = 0; x < SizeX; x++)
        {
            for (int y = 0; y < SizeX; y++)
            {
                Tiles[x, y] = 0;
            }
        }
        Tiles[1, 0] = 1;
        Tiles[1, 1] = 2;
        Tiles[1, 2] = 3;
        Tiles[1, 3] = 4;
        Tiles[1, 4] = 5;
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //this is UI setup part
        for (int x = 0; x < SizeX; x++)
        {
            for (int y = 0; y < SizeX; y++)
            {
                if (IsOdd(x))
                {
                    GameObject T = TileTypes[Tiles[x, y]].TileUiPreFap;
                    Instantiate(T, transform.position = new Vector3((float)(y * 0.86), 0, (float)(x * 0.75)), Quaternion.identity);
                }
                else
                {
                    Instantiate(TileTypes[Tiles[x, y]].TileUiPreFap, transform.position = new Vector3((float)(y * 0.86 + 0.43), 0, (float)(x * 0.75)), Quaternion.identity);
                }
            }
        }
    }
    public static bool IsOdd(float value)
    {
        return value % 2 != 0;
    }
}
