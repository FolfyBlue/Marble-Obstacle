using UnityEngine;

public class bully : MonoBehaviour
{
    public GameObject player;
    public checkTrigger trigger;
    public float speed;
    public DebugMode debugMode;

    private checkTrigger homeObj;
    private GameObject entity;
    private GameObject area;
    private Vector3 home;
    private Vector3 goal;
    private bool move;
    private float curSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        entity = transform.Find("entity").gameObject;
        area = transform.Find("area").gameObject;
        homeObj = transform.Find("home").gameObject.GetComponent<checkTrigger>();
        home = area.transform.position;
        home.y = area.GetComponent<MeshRenderer>().bounds.min.y + (entity.transform.localScale.y / 2);
        entity.transform.position = home;
    }

    // Update is called once per frame
    private void Update()
    {
        area.GetComponentInChildren<MeshRenderer>().enabled = debugMode.isDebugOn;
        homeObj.gameObject.GetComponentInChildren<MeshRenderer>().enabled = debugMode.isDebugOn;
        move = false;
        curSpeed = speed;
        if (trigger.collisionStay)
        {
            goal = player.transform.position;
            move = true;
        }
        else if (!homeObj.collisionStay)
        {
            goal = home;
            move = true;
            curSpeed = speed / 2;
        }

        if (move)
        {
            entity.transform.LookAt(goal);
            entity.transform.position += entity.transform.forward * curSpeed * Time.deltaTime;
        }
    }
}