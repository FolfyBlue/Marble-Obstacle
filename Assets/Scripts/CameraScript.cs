using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private List<Transform> viewPoints;
    private Transform cam;
    private int target;
    private int max = -1;
    private bool curDebugMode;

    public GameObject player;
    public int moveDelay = 100;
    public DebugMode debugMode;

    private void Start()
    {
        curDebugMode = true;
        viewPoints = new List<Transform>(transform.childCount - 1);
        foreach (Transform child in transform)
        {
            if (child.gameObject.name != "Camera")
            {
                viewPoints.Add(child);
            }
        }

        foreach (Transform child in transform)
        {
            if (child.gameObject.name != "Camera")
            {
                viewPoints[int.Parse(child.gameObject.name)] = child;
                max++;
            }
            else
            {
                cam = child;
            }
        }
    }

    public void setPos(int pos)
    {
        target = pos;
    }

    private void Update()
    {
        if (curDebugMode != debugMode.isDebugOn)
        {
            curDebugMode = debugMode.isDebugOn;
            foreach (Transform child in viewPoints)
            {
                child.gameObject.GetComponent<MeshRenderer>().enabled = curDebugMode;
            }
        }

        cam.LookAt(player.transform.position);

        if (Input.GetKeyDown("q"))
        {
            target++;
        }
        if (Input.GetKeyDown("e"))
        {
            target--;
        }

        if (target > max)
        {
            target = 0;
        }
        else if (target < 0)
        {
            target = max;
        }

        viewPoints[target].GetComponent<MeshRenderer>().enabled = debugMode.isDebugOn;
        cam.position = Vector3.MoveTowards(cam.position, viewPoints[target].position, moveDelay * Time.deltaTime); //Move smoothly towards the poisition
    }
}