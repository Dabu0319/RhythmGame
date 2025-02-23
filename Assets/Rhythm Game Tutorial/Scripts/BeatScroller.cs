﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;
    public bool hasStarted;
    
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        //转到GameManager
        // if (!hasStarted)
        // {
        //     if (Input.anyKeyDown)
        //     {
        //         hasStarted = true;
        //     }
        // }
        // else
        // {
        //     transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        // }

        if (hasStarted)
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }

    }
}
