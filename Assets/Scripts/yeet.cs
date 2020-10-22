using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeet : MonoBehaviour
{
    public float yeetPower;
    public bool toYeetOrNot;
    private GameObject arm;
    // Start is called before the first frame update
    void Start()
    {
        arm = transform.Find("Arm").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (toYeetOrNot)
        {
            arm.transform.RotateAround(transform.position, Vector3.up, yeetPower);
        }
    }
}
