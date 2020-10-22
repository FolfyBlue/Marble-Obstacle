using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint : MonoBehaviour
{
    private bool old = false;
    public int camCheckpoint;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if ((!old) & (other.gameObject.name == "Player"))
        {
            PlayerPrefs.SetFloat("checkpointX" + SceneManager.GetActiveScene().name, transform.position.x);
            PlayerPrefs.SetFloat("checkpointY" + SceneManager.GetActiveScene().name, this.GetComponent<MeshFilter>().mesh.bounds.size.y + 1);
            PlayerPrefs.SetFloat("checkpointZ" + SceneManager.GetActiveScene().name, transform.position.z);  //Save the coordinates of the checkpoint to playerprefs
            PlayerPrefs.SetInt("camPos" + SceneManager.GetActiveScene().name, camCheckpoint);
            old = true;
        }
    }
}