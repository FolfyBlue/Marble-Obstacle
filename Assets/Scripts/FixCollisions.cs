using UnityEngine;

public class FixCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        transform.position = new Vector3(transform.position.x, (float)(transform.position.y - 0.5), transform.position.z);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}