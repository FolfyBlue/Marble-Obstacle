using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public GameLogic gl;
    public bool isDebugOn;
    public bool noclip;
    public float noclipSpeed;
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        isDebugOn = PlayerPrefs.GetInt("isDebugOn") == 1;
        controls.Debug.Enable();
    }

    private void Update()
    {
        if (controls.Debug.DebugView.triggered)
        {
            isDebugOn = !isDebugOn;
            PlayerPrefs.SetInt("isDebugOn", isDebugOn ? 1 : 0);
        }
        if (controls.Debug.Noclip.triggered)
        {
            noclip = !noclip;
            var rb = gl.player.GetComponent<Rigidbody>();
            rb.isKinematic = noclip;
        }

        gl.player.GetComponent<Rigidbody>().isKinematic = noclip;
        if (noclip)
        {
            var fwd = gl.player.transform.forward;
            fwd.y = 0;
            fwd = fwd.normalized;

            var right = gl.player.transform.right;
            right.y = 0;
            right = right.normalized;

            var input = controls.Debug.NoclipMovement.ReadValue<Vector2>();
            var movement = new Vector3
            {
                z = input.y,
                y = controls.Debug.NoclipFly.ReadValue<Vector2>().y,
                x = input.x
            }.normalized;

            Debug.Log(controls.Debug.NoclipFly.ReadValue<Vector2>().y);

            gl.player.transform.Translate(movement * noclipSpeed * Time.deltaTime);
        }

        gl.startPoint.GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        gl.endPoint.GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].GetComponentInChildren<MeshRenderer>().enabled = isDebugOn;
        }
    }
}