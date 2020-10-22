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
            "\nScene ID: " + SceneManager.GetActiveScene().buildIndex +
            "\n\n----==Camera==----" +
            "\nVector3: " + cam.transform.position +
            "\nMax height: " + cam.maxHeight +
            "\nHeight: " + cam.curHeight +
            "\nPosition: " + cam.cameraPos +
            "\nReady: " + ((cam.timestamp - Time.time) < 0) +
            "\n\n----==GameLogic==----" +
            "\nCheckpoint: " + cam.gl.currentCheckpoint +
            "\nWon: " + cam.gl.won +
            "\n\n----=Player==----" +
            "\nVector3: " + cam.PlayerPos.position;
    }
}