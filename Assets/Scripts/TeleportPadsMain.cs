//Don't look at this code it's terrible
//Please, have some respect

using UnityEngine;

public class TeleportPadsMain : MonoBehaviour
{
    public int camPos1;
    public int camPos2;
    public CameraScript cs;
    public float wait;
    private float lastTeleport;

    private GameObject pad1;
    private GameObject pad2;

    private GameObject player;
    private checkTrigger point1;
    private checkTrigger point2;

    private GameObject security1;
    private GameObject security2;

    private void Start()
    {
        lastTeleport = Time.time;
        pad1 = transform.Find("1").gameObject;
        var cam1 = pad1.transform.Find("Camera").gameObject;  //Select camera of first telepad
        var cam1view = new RenderTexture(512, 512, 16); // Create a rendered texture

        pad2 = transform.Find("2").gameObject;
        var cam2 = pad2.transform.Find("Camera").gameObject;
        var cam2view = new RenderTexture(512, 512, 16);

        cam2.GetComponent<Camera>().targetTexture = cam2view; // Assing the camera's rendering to the render texture
        cam1.GetComponent<Camera>().targetTexture = cam1view;

        var cylinder1 = pad1.transform.Find("Cylinder").gameObject; //Find the cylinder in which the player stands
        cylinder1.GetComponent<MeshRenderer>().material.mainTexture = cam2view; // Assign it's material to the render texture

        var cylinder2 = pad2.transform.Find("Cylinder").gameObject;
        cylinder2.GetComponent<MeshRenderer>().material.mainTexture = cam1view;

        point1 = cylinder1.GetComponent<checkTrigger>();
        point2 = cylinder2.GetComponent<checkTrigger>();

        security1 = pad1.transform.Find("security").gameObject;
        security2 = pad2.transform.Find("security").gameObject;

        security1.SetActive(false);
        security2.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (wait + lastTeleport < Time.time)
        {
            player = GameObject.Find(point1.objName);

            if (point1.collisionExit)
            {
                cs.setPos(camPos1);
                point1.collisionExit = false;
            }

            if (point1.collisionEnter)
            {
                cs.setPos(camPos2);
            }

            if (point1.collisionStay)
            {
                security1.SetActive(true);
                security2.SetActive(false);
                if (cs.doneMoving)
                {
                    player.transform.position = point2.transform.position;
                    lastTeleport = Time.time;
                }
            }

            if (point2.collisionEnter)
            { //move the camera when we enter the teleporter
                cs.setPos(camPos1);
            }

            if (point2.collisionExit)
            { //move the camera when we exit the teleporter, fix to staying inside the teleporter and the camera not moving
                cs.setPos(camPos2);
                point2.collisionExit = false;
            }

            if (point2.collisionStay)
            {  //Turn on/off the barriers that make the player stuck on the teleporter during the teleportation
                security1.SetActive(false);
                security2.SetActive(true);
                if (cs.doneMoving) //If the camera is ready, teleport the player
                {
                    player.transform.position = point1.transform.position;
                    lastTeleport = Time.time;
                }
            }
        }
    }
}