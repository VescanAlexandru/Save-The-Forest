﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleTry : MonoBehaviour
{
   // public float degreesPerSecond = 15.0f;
    public float inaltime = 0.5f;
    public float fregventa = 1f;
    public float inaltimeApaSus;
    public float inaltimeApaJos;
    public Renderer bula;
    public Material mat1;
    public Material ma2;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
      //  transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * fregventa) * inaltime;

        transform.position = tempPos;      
    
            if (transform.position.y <= inaltimeApaJos )
            {
                bula.material= mat1;
            }
           if (transform.position.y >= inaltimeApaSus)
        {
            bula.material = ma2;
        }
        }
    }


