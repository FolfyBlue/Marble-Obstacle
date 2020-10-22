using UnityEngine;

public class PushingObstacleScript : MonoBehaviour
{
    public float delay = 1;
    public int distance = 1;
    public int speed = 1;
    [Range(0, 2)] public int direction;

    private float timestamp = 0;
    private bool forward = true;
    private Vector3 target;
    private Vector3 startpos;

    private void Start()
    {
        startpos = transform.position;
        target = startpos;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time >= timestamp && Vector3.Distance(transform.position, target) < 0.1f) //If the object's finished moving and is at it's target
        {
            timestamp = Time.time + delay + speed / 2; //The object is moving..
            if (forward)
            {
                forward = !forward;
                if (direction == 0)
                { //Where to move depending on direction
                    target = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
                }
                else if (direction == 1)
                {
                    target = new Vector3(transform.position.x, transform.position.y, transform.position.z + distance);
                }
                else
                {
                    target = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
                }
            }
            else
            {
                forward = !forward;
                target = startpos;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); //Move towards target
    }
}