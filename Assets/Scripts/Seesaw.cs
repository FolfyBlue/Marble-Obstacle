using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Seesaw : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        var max = transform.Find("Max").gameObject;
        var max2 = transform.Find("Max2").gameObject;
        var start = transform.Find("StartingPos").gameObject;
        Physics.IgnoreCollision(start.GetComponent<Collider>(), player.GetComponent<Collider>());
        Physics.IgnoreCollision(max.GetComponent<Collider>(), player.GetComponent<Collider>());
        Physics.IgnoreCollision(max2.GetComponent<Collider>(), player.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}