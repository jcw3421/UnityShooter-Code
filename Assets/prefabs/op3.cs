using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class op3 : MonoBehaviour
{
    public GameObject block;
    public Transform blockPoint;
    public int row = 40;
    public int col = 40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Vector3 pos = blockPoint.position;
        for (int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                Instantiate(block, pos, blockPoint.rotation);
                pos.z = blockPoint.position.z + c * 1.0f;
                pos.y = r * 1.1f;
            }
        }
        //static void Main(string[] args)
        //int a = 10;
        //int b = 10;
        //float c = 20.0f;
        //double d = 30.01;
        //bool check = false;
        //if ( a > b )
        // a = (int)c;
        // c = (float)d;
        //for(int i = 0; i < 10; i++)
        //for(int j = 0; j < 5; j++)
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
