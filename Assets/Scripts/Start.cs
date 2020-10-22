using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    private bool old = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!old)
        {
            PlayerPrefs.SetFloat("checkpointX" + SceneManager.GetActiveScene().name, transform.position.x);
            PlayerPrefs.SetFloat("checkpointY" + SceneManager.GetActiveScene().name, transform.position.y);
            PlayerPrefs.SetFloat("checkpointZ" + SceneManager.GetActiveScene().name, transform.position.z);
            old = true;
        }
    }
}