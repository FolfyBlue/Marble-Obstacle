using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public GameLogic gl;
    public bool isDebugOn;
    public bool noclip;
    // Start is called before the first frame update
    void Start()
    {
        isDebugOn = PlayerPrefs.GetInt("isDebugOn") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            isDebugOn = !isDebugOn;
            PlayerPrefs.SetInt("isDebugOn", isDebugOn ? 1 : 0);
        }
        if (Input.GetKeyDown("n"))
        {
            noclip = !noclip;
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
 