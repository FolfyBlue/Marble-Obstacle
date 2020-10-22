using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTrigger : MonoBehaviour
{
    public bool collisionEnter;
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
        }
    }
}
