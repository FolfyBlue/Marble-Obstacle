using UnityEngine;

public class yeet : MonoBehaviour
{
    public float yeetPower;
    public bool toYeetOrNot;
    private GameObject arm;

    // Start is called before the first frame update
    private void Start()
    {
        arm = transform.Find("Arm").gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        if (toYeetOrNot)
        {
            arm.transform.RotateAround(transform.position, Vector3.up, yeetPower);
        }
    }
}