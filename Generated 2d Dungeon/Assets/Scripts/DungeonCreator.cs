﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreator : MonoBehaviour
{

    private float radius = 15;
    private float tileSize = 4;
    private float pointX;
    private float pointY;
    private float rWidth = 10;
    private float rHeight = 10;
    private float rooms = 5;
    
    void Start()
    {
        GetRandomPointInCircle(radius, out pointX, out pointY);
        Roundm( out pointX, pointX, tileSize);
        Roundm( out pointY, pointY, tileSize);

        for (var i = 0; i <= rooms; i++)
        {
            CreateRoom(pointX, pointY);
        }
        
    }

    void GetRandomPointInCircle(float radius, out float pointX, out float pointY)
    {
        float t = 2 * Mathf.PI * Random.value;
        float u = Random.value + Random.value;
        float r = 1;
        if (u >= 1)
        {
            r = 2 - u;
        }
        else
        {
            r = u;
        }
        pointX = radius * r * Mathf.Cos(t);
        pointY = radius * r * Mathf.Sin(t);

        

    }
    
    void Roundm( out float outPoint, float n,float m)
    {
        outPoint = Mathf.Floor(((n + m - 1) / m)) * m;
    }

    void CreateRoom(float pointX, float pointY)
    {

    }
}


