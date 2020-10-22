using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public CameraScript cam;

    // Update is called once per frame
    private void Update()
    {
        GetComponent<Text>().text = "DEBUG" +
            "\n----==Scene==----" +
            "\nScene name: " + SceneManager.GetActiveScene().name +
            "\nScene ID: " + SceneManager.GetActiveScene().buildIndex;
    }
}