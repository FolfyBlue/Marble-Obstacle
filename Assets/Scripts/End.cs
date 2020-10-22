using UnityEngine;

public class End : MonoBehaviour
{
    public GameLogic gl;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        gl.finish();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}