using UnityEngine;

public class HeadCollision : MonoBehaviour
{
    public bool collided = false;
    public GameObject catapult;

    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.name == "Player")
        {
            collided = true;
        }
    }

    private void FixedUpdate()
    {
        if (catapult.GetComponent<Catapult>().collided)
        {
            /* if (!collided) {
                 collided = false;
             }*/
        }
    }
}