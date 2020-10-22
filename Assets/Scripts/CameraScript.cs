using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameLogic gl;
    public GameObject globalGround;
    public Transform PlayerPos;
    public int cameraHeight = 25; // Starting Height
    public int heightDistance = 50; //How much up we go
    public int cameraPos = 0;
    public int moveDelay = 100;
    public int curHeight;
    public int maxHeight;
    public float timestamp;

    private Vector3 ground;
    private Vector3 targetPosition;
    private int height;

    // Start is called before the first frame update
    private void Start()
    {
        curHeight = 1;
        ground = globalGround.GetComponent<Renderer>().bounds.size / 2;
        targetPosition = new Vector3(ground.x, cameraHeight, ground.z); // Moves Sides of the global ground
        transform.position = new Vector3(ground.x, cameraHeight, ground.z); // Sets position to the sides of the global ground
    }

    public void nextCorner()
    {
        timestamp = (float)(Time.time + (moveDelay / 100) + 0.2);
        if (cameraPos >= 3)
        {
            cameraPos = -1;
        }
        setPos(cameraPos + 1, true);
    }

    public void mid()
    {
        timestamp = (float)(Time.time + (moveDelay / 100) + 0.2);
        if (cameraPos == 4)
        {
            setPos(0, true);
            return;
        }
        setPos(4, true);
    }

    public void previousCorner()
    {
        timestamp = (float)(Time.time + (moveDelay / 100) + 0.2);
        if (cameraPos < 1)
        {
            cameraPos = 4;
        }
        setPos(cameraPos - 1, true);
    }

    public void setPos(int pos, bool smooth)
    {
        cameraPos = pos;
        switch (pos)
        {
            case 0:
                targetPosition = new Vector3(ground.x, transform.position.y, ground.z); //Ground corners
                break;

            case 1:
                targetPosition = new Vector3(ground.x, transform.position.y, -ground.z);
                break;

            case 2:
                targetPosition = new Vector3(-ground.x, transform.position.y, -ground.z);
                break;

            case 3:
                targetPosition = new Vector3(-ground.x, transform.position.y, ground.z);
                break;

            case 4:
                targetPosition = new Vector3(0, transform.position.y + heightDistance, 0);  //Center of the ground, slightly higher
                break;
        }
        if (!smooth)
        {
            transform.position = targetPosition;
        }
    }

    public void upwards()
    {
        curHeight++;
        timestamp = (float)(Time.time + heightDistance * 0.01);
    }

    public void downwards()
    {
        curHeight--;
        timestamp = (float)(Time.time + heightDistance * 0.01);
    }

    // Update is called once per frame
    private void Update()
    {
        targetPosition.y = heightDistance * curHeight;
        if (targetPosition.y < cameraHeight || targetPosition.y == heightDistance)
        {
            targetPosition.y = cameraHeight;
            curHeight = 1;
        }

        if (curHeight > maxHeight)
        {
            curHeight = maxHeight;
        }
        if (cameraPos == 4)
        {
            targetPosition.y += cameraHeight;
        }

        if (!gl.won)
        {
            if (Input.GetKey("q") && Time.time >= timestamp)
            {
                nextCorner();
            }
            if (Input.GetKey("e") && Time.time >= timestamp)
            {
                previousCorner();
            }
            if (Input.GetKey("x") && Time.time >= timestamp)
            {
                mid();
            }
            if (Input.GetKey("z") && Time.time >= timestamp)
            {
                upwards();
            }
            if (Input.GetKey("c") && Time.time >= timestamp)
            {
                downwards();
            }

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveDelay * Time.deltaTime); //Move smoothly towards the poisition
            transform.LookAt(PlayerPos);
        }
    }
}