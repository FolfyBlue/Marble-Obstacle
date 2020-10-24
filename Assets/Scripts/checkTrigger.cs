using UnityEngine;

public class checkTrigger : MonoBehaviour
{
    public bool collisionEnter;
    private bool enterCheck;
    public bool collisionExit;
    public bool collisionStay;
    public string objName;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.name == objName)
        {
            collisionEnter = true;
            collisionExit = false;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.name == objName)
        {
            collisionEnter = false;
            collisionExit = true;
            collisionStay = false;
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.name == objName)
        {
            collisionStay = true;
            if (enterCheck)
            {
                collisionEnter = false;
                enterCheck = false;
            }
            if (collisionEnter)
            {
                enterCheck = true;
            }
        }
    }
}