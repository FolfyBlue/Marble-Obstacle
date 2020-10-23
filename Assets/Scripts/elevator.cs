using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public float height;
    public float speed;
    public bool down;

    private GameObject tmp;
    private List<GameObject> pickups = new List<GameObject>();
    private Vector3 target;
    private Vector3 start;

    // Start is called before the first frame update
    private void Start()
    {
        tmp = transform.Find("Core").gameObject;
        tmp.transform.localScale = new Vector3(1, height, 1);
        tmp.transform.position = new Vector3(tmp.transform.position.x, tmp.transform.localScale.y, tmp.transform.position.z);
        target = tmp.transform.position;
        target.y = tmp.transform.localScale.y * 2;

        tmp = transform.Find("Pickup").gameObject;
        for (int i = 1; i < (int)height * 0.6875; i++)
        {
            pickups.Add(Instantiate(tmp, new Vector3(tmp.transform.position.x, tmp.transform.position.y + (i * 3), tmp.transform.position.z), transform.rotation));
            pickups[i - 1].transform.rotation = tmp.transform.rotation;
            pickups[i - 1].transform.parent = tmp.transform.parent;
        }
        target.x = tmp.transform.position.x;
        target.z = tmp.transform.position.z;
        start = tmp.transform.position;
        tmp.SetActive(false);

        tmp = transform.Find("SafeR").gameObject;
        tmp.transform.localScale = new Vector3(tmp.transform.localScale.x, height * 2 + 2, tmp.transform.localScale.z);
        tmp.transform.position = new Vector3(tmp.transform.position.x, height, tmp.transform.position.z);

        tmp = transform.Find("SafeL").gameObject;
        tmp.transform.localScale = new Vector3(tmp.transform.localScale.x, height * 2 + 2, tmp.transform.localScale.z);
        tmp.transform.position = new Vector3(tmp.transform.position.x, height, tmp.transform.position.z);

        if (down)
        {
            Vector3 tempVect = start;
            start = target;
            target = tempVect;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (GameObject pickup in pickups)
        {
            pickup.transform.position = Vector3.MoveTowards(pickup.transform.position, target, speed * Time.deltaTime);
            if (pickup.transform.position == target)
            {
                pickup.transform.position = start;
            }
        }
    }
}