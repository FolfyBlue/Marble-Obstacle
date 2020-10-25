using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private List<Transform> viewPoints;
    private Transform cam;
    private int target;
    private int max = -1;
    private bool curDebugMode;
    private Controls controls;
    private bool force;

    public bool doneMoving;
    public GameObject player;
    public int moveDelay = 100;
    public DebugMode debugMode;

    private void Awake()
    {
        controls = new Controls();
    }

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
        controls.Camera.Enable();
    }

    public void setPos(int pos, bool force)
    {
        doneMoving = false;
        target = pos;
        force = this.force;
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

        var goNext = controls.Camera.Next.triggered;
        var goPrev = controls.Camera.Previous.triggered;

        if (goNext)
        {
            target++;
        }
        if (goPrev)
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

        if (force)
        {
            cam.position = viewPoints[target].position;
            force = false;
        }

        viewPoints[target].GetComponent<MeshRenderer>().enabled = debugMode.isDebugOn;
        cam.position = Vector3.MoveTowards(cam.position, viewPoints[target].position, moveDelay * Time.deltaTime); //Move smoothly towards the poisition

        doneMoving = (cam.position == viewPoints[target].position);
    }
}