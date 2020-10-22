using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private List<Transform> viewPoints;
    private Transform cam;
    private int target;
    private int max = 0;

    public GameObject player;
    public int moveDelay = 100;
    private void Start()
    {
        viewPoints = new List<Transform>(transform.childCount-1);
        foreach (Transform child in transform)
        {
            viewPoints.Add(child);
        }
            foreach (Transform child in transform)
        {
            if (child.gameObject.name != "Camera")
            {
                Debug.Log(int.Parse(child.gameObject.name));
                viewPoints[int.Parse(child.gameObject.name)] = child;
                max++;
            }
            else
            {
                cam = child;
            }
        }
    }

    private void Update()
    {
        cam.LookAt(player.transform.position);

        if (Input.GetKeyDown("q"))
        {
            target++;
        }
        if (Input.GetKeyDown("e"))
        {
            target--;
        }

        if(target > max)
        {
            target = 0;
        } else if (target < 0) {
            target = max;
        }

        Debug.Log(viewPoints[target].gameObject.name);
        Debug.Log(target);
        cam.position = Vector3.MoveTowards(cam.position, viewPoints[target].position, moveDelay * Time.deltaTime); //Move smoothly towards the poisition

    }
}