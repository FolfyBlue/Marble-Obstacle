using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    private Controls controls;

    public float speed = 0.01f;
    public Transform cam;
    public float gravity = 10;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var fwd = cam.forward; //Fwd and right for the player is the camera's facing forward and right
        fwd.y = 0;
        fwd = fwd.normalized;

        var right = cam.right;
        right.y = 0;
        right = right.normalized;

        var input = controls.Player.Movement.ReadValue<Vector2>();

        rb.AddForce(input.y * fwd * speed, ForceMode.VelocityChange); // Up down
        rb.AddForce(input.x * right * speed, ForceMode.VelocityChange); // Left right

        rb.AddForce(Physics.gravity * gravity * rb.mass);
    }

    private void LateUpdate()
    {
    }
}