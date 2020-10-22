using UnityEngine;

public class Catapult : MonoBehaviour
{
    public bool collided = false;
    public int speed = 10;
    public float size;
    public GameObject arm;
    public GameObject hitbox;
    [Range(0, 360)] public int MaxRotation;
    [Range(0, 3)] public int direction; //0 = +z, 1 = +x, 2 = -z, 3 = -x,

    // Start is called before the first frame update
    private void Start()
    {
        if (direction == 0)
        {
            arm.transform.localScale = new Vector3(1, arm.transform.localScale.y, size);
            arm.transform.position = new Vector3(arm.transform.position.x, arm.transform.position.y, (float)(arm.transform.position.z + (size * 0.5)));
            transform.RotateAround(arm.transform.position, new Vector3(90, 0, 0), speed * Time.deltaTime);
        }
        else if (direction == 1)
        {
            arm.transform.localScale = new Vector3(size, arm.transform.localScale.y, 1);
            arm.transform.position = new Vector3((float)(arm.transform.position.x + (size * 0.5) + 0.5), arm.transform.position.y, arm.transform.position.z - 1);
        }
        else if (direction == 2)
        {
            arm.transform.localScale = new Vector3(1, arm.transform.localScale.y, size);
            arm.transform.position = new Vector3(arm.transform.position.x, arm.transform.position.y, (float)(arm.transform.position.z + -(size * 0.5) - 1.5));
            transform.RotateAround(arm.transform.position, new Vector3(-90, 0, 0), speed * Time.deltaTime);
        }
        else if (direction == 3)
        {
            arm.transform.localScale = new Vector3(size, arm.transform.localScale.y, 1);
            arm.transform.position = new Vector3((float)(arm.transform.position.x + -(size * 0.5) - 0.5), arm.transform.position.y, (arm.transform.position.z - 1));
            transform.RotateAround(arm.transform.position, new Vector3(0, 0, 90), speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        Debug.Log(transform.rotation.eulerAngles.x);
        Debug.Log(MaxRotation);
        collided = hitbox.GetComponent<HeadCollision>().collided;
        if (direction == 0)
        {
            if ((collided) && (transform.rotation.eulerAngles.x < MaxRotation))
            {
                transform.RotateAround(arm.transform.position, new Vector3(90, 0, 0), speed * Time.deltaTime);
            }
        }
        else if (direction == 1)
        {
        }
        else if (direction == 2)
        {
            if ((collided) && (transform.rotation.eulerAngles.x > 360 - MaxRotation))
            {
                transform.RotateAround(arm.transform.position, new Vector3(-90, 0, 0), speed * Time.deltaTime);
            }
        }
        else if (direction == 3)
        {
            if ((collided) && (transform.rotation.eulerAngles.z < MaxRotation))
            {
                transform.RotateAround(arm.transform.position, new Vector3(0, 0, 90), speed * Time.deltaTime);
            }
        }
    }
}