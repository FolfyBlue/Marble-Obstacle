using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public float endTime;
    public GameObject stop;
    public Button exit;

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = new Vector3(transform.position.x, stop.transform.position.y, transform.position.z); //Set the target to the stop obj
        exit.onClick.AddListener(Exit);
    }

    private void Exit()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, endTime * Time.deltaTime);  //Go towards the stop obj
    }
}