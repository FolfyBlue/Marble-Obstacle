using UnityEngine;

public class TriggerLaunch : MonoBehaviour
{
    public bool collided;
    public GameObject catapult;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            collided = true;
        }
    }

    private void OnTriggerStay(Collider other)

    {
        if (other.gameObject.name == "Player")
        {
            collided = true;
        }
        else
        {
            collided = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            collided = false;
        }
    }

    private void Update()
    {
    }
}