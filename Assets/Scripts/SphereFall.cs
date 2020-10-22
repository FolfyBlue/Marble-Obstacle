using System.Collections.Generic;
using UnityEngine;

public class SphereFall : MonoBehaviour
{
    public int sphereCount;
    public GameObject sphereExample;
    public int moveDelay;

    private List<GameObject> spheres = new List<GameObject>();

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < sphereCount; i++)
        {
            spheres.Add(Instantiate(sphereExample, new Vector3(Random.Range(-100, 400), Random.Range(300, 1000), -10), transform.rotation));  // Duplicate the exemple sphere
            spheres[i].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f); // Randomize the color
            spheres[i].GetComponent<Rigidbody>().velocity = new Vector3(0, -300, 0); // Make it fall at -300
        }
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (GameObject obj in spheres)
        {
            if (obj.transform.position.y < -45)
            {
                obj.transform.position = new Vector3(Random.Range(-100, 400), Random.Range(300, 1000), -10); //If it's under y = -45, put it back up
                if (obj.GetComponent<Rigidbody>().velocity.y < -1000)
                {
                    obj.GetComponent<Rigidbody>().velocity = new Vector3(0, -300, 0); //If it's too fast, reset the speed
                }
            }
        }
    }
}