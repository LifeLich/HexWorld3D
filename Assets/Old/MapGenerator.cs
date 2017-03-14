using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public int hight;
    public int wight;
    public GameObject Title;
    public GameObject City;
    // Use this for initialization
    void Start () {
        for (float i = 0; i < hight; i++)
        {
            for (float j = 0; j < wight; j++)
            {
                if (IsOdd(i))
                {
                    Instantiate(Title, transform.position = new Vector3((float)(j * 0.86), 0, (float)(i * 0.75)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Title, transform.position = new Vector3((float)(j * 0.86 + 0.43), 0, (float)(i * 0.75)), Quaternion.identity);
                }
            }
        }
        Instantiate(City, transform.position = new Vector3((float)(hight / 2 * 0.86), 0, (float)(wight / 2 * 0.75)), Quaternion.identity);

    }
    public static bool IsOdd(float value)
    {
        return value % 2 != 0;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
