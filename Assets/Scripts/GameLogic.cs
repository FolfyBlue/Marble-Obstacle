using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public bool won = false;
    public GameObject player;
    public GameObject globalGround;
    public GameObject startPoint;
    public GameObject endPoint;
    public GameObject deathScreen;
    public ParticleSystem deathAnim;

    public CameraScript cam;
    public EndScreen endScreen;

    public Vector3 currentCheckpoint;

    private bool isAnimationPlaying = false;
    private float minY;
    private float wait = float.MaxValue;

    // Start is called before the first frame update
    private void Start()
    {
        minY = globalGround.transform.position.y - 25;  //Death position

        if (PlayerPrefs.HasKey("checkpointX" + SceneManager.GetActiveScene().name))
        {
            currentCheckpoint = new Vector3(
                PlayerPrefs.GetFloat("checkpointX" + SceneManager.GetActiveScene().name),
                PlayerPrefs.GetFloat("checkpointY" + SceneManager.GetActiveScene().name),
                PlayerPrefs.GetFloat("checkpointZ" + SceneManager.GetActiveScene().name)
            ); // Place player back at the previous checkpoint if he has one
            player.transform.position = (currentCheckpoint);
        }
        else
        {
            player.transform.position = (startPoint.transform.position); //Place the player at the starting point
        }
        if (PlayerPrefs.HasKey("camPos" + SceneManager.GetActiveScene().name))
        {
            cam.setPos(PlayerPrefs.GetInt("camPos" + SceneManager.GetActiveScene().name)); // Place the cam back at where the player had it before dying
        }
        isAnimationPlaying = false;
        deathAnim.gameObject.SetActive(false);
    }

    public void finish()
    {
        endScreen.trigger();  // Triggers end screen animation
        won = true;
    }

    public void death()
    {
        if (won | isAnimationPlaying)
        {
            return;
        }
        deathAnim.gameObject.SetActive(true);
        deathScreen.SetActive(true);
        player.GetComponent<MeshRenderer>().enabled = false;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        //PlayerPrefs.SetInt("camPos" + SceneManager.GetActiveScene().name, cam.cameraPos); // Save current cam pos
        var anim = deathScreen.GetComponent<Animator>();
        isAnimationPlaying = true;
        wait = Time.time + anim.GetCurrentAnimatorStateInfo(0).length;
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.transform.position.y < minY)
        {
            death();
        }
        if (wait < Time.time) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
} 