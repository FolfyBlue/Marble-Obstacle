using UnityEngine;

public class isInWall : MonoBehaviour
{
    public GameLogic GameLogic;

    private void OnTriggerStay(Collider other)

    {
        if (other.gameObject.tag == "crusher")
        {
            GameLogic.death();
        }
    }
}