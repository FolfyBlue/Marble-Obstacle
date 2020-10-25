using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPad : MonoBehaviour
{
    public float padSpeed;
    public Vector2 Scroll = new Vector2(0.05f, 0.05f);
    private Vector2 Offset = new Vector2(0f, 0f);
    private Renderer render;

    // Start is called before the first frame update
    private void Start()
    {
        render = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        Offset += Scroll * Time.deltaTime;
        render.material.SetTextureOffset("_MainTex", Offset); //Scroll texture, stolen from internet
    }

    private void OnTriggerStay(Collider collision)
    {
        var obj = collision.GetComponent<Collider>().gameObject;
        if (obj.GetComponent<Rigidbody>() == null)
        {
            return;
        }
        obj.GetComponent<Rigidbody>().AddForce(new Vector3(Scroll.x, 0, Scroll.y) * padSpeed);
    }
}