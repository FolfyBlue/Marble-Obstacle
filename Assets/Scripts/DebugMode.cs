﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public GameLogic gl;
    public bool isDebugOn;
    public bool noclip;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("p") & timer - Time.time <= 0)
        {
            timer = (float)(Time.time + 0.2);
            isDebugOn = !isDebugOn;
        }
        if (Input.GetKey("n") & timer - Time.time <= 0)
        {
            timer = (float)(Time.time + 0.2);
            noclip = !noclip    ;
        }


        gl.player.GetComponent<Rigidbody>().isKinematic = noclip;
        if (noclip)
        {
            var fwd = gl.player.transform.forward;
            fwd.y = 0;
            fwd = fwd.normalized;

            var right = gl.player.transform.right;
            right.y = 0;
            right = right.normalized;

            if (Input.GetKey("w"))
            {
                gl.player.transform.position += fwd;
            }
            if (Input.GetKey("s"))
            {
                gl.player.transform.position -= fwd;
            }
            if (Input.GetKey("a"))
            {
                gl.player.transform.position -= right;
            }
            if (Input.GetKey("d"))
            {
                gl.player.transform.position += right;
            }
            if (Input.GetKey("f"))
            {
                gl.player.transform.position += Vector3.up;
            }
            if (Input.GetKey("r"))
            {
                gl.player.transform.position -= Vector3.up;
            }
        }

        gl.startPoint.GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        gl.endPoint.GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        }
    }
}
 