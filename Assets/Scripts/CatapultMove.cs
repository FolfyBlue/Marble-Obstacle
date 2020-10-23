using System.Collections;
using UnityEngine;

public class CatapultMove : MonoBehaviour
{
    private bool collided;

    public GameObject planes;
    public GameObject hitbox;
    public Rigidbody rb;
    public int force;
    public float maxSpeed;

    private float startPos;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LateStart((float)0.1));
    }

    private IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        startPos = transform.position.y;  //Save the starting position
    }

    // Update is called once per frame
    private void Update()
    {
        collided = hitbox.GetComponent<TriggerLaunch>().collided;
        float speed = Vector3.Magnitude(rb.velocity);
        if (collided && speed < maxSpeed)
        {
            planes.SetActive(false); //Turn off planes that help the player get in
            rb.AddForce(0, force, 0); //Launch
        }
        if (!collided && transform.position.y <= startPos)
        {
            planes.SetActive(true); //Turn the planes back on if the catapult's back at it's original pos
        }
    }
}