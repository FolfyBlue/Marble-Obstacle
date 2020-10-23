using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float force;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.name == "Player")
        {
            collision.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
        }
    }
}
