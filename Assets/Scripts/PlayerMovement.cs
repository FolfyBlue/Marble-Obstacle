using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 0.01f;
    public Transform cam;
    public float gravity = 10;

    // Update is called once per frame
    private void FixedUpdate()
    {
        var fwd = cam.forward; //Fwd and right for the player is the camera's facing forward and right
        fwd.y = 0;
        fwd = fwd.normalized;

        var right = cam.right;
        right.y = 0;
        right = right.normalized;

        if (Input.GetKey("w"))
        {
            rb.AddForce(fwd * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-fwd * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-right * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(right * speed, ForceMode.VelocityChange);
        }
        rb.AddForce(Physics.gravity * gravity * rb.mass);
    }

    private void LateUpdate()
    {
    }
}