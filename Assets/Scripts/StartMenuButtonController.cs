using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuButtonController : MonoBehaviour
{
    public Button resetBtn;
    public Button exitBtn;
    public Button startBtn;

    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.HasKey("curLvl"))
        {
            startBtn.GetComponentInChildren<Text>().text = "Resume";
        }
        else
        {
            exitBtn.transform.position = resetBtn.transform.position;
            resetBtn.transform.position = new Vector3(100000, 100000, 100000);
        }
        resetBtn.onClick.AddListener(Reset);
        exitBtn.onClick.AddListener(Exit);
        startBtn.onClick.AddListener(Play);
    }

    private void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Exit()
    {
        Application.Quit();
    }

    private void Play()
    {
        if (PlayerPrefs.HasKey("curLvl"))
        {
            if (PlayerPrefs.GetInt("curLvl") < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("curLvl"));
            }
            SceneManager.LoadScene(PlayerPrefs.GetInt("curLvl") - 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}