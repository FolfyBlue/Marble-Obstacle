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

    private void Update()
    {
        exitBtn.gameObject.SetActive(!transform.Find("LevelSelectPopup").gameObject.active);
        startBtn.gameObject.SetActive(!transform.Find("LevelSelectPopup").gameObject.active);
        resetBtn.gameObject.SetActive(!transform.Find("LevelSelectPopup").gameObject.active);
    }

    private void Play()
    {
        if (PlayerPrefs.HasKey("curLvl"))
        {
            transform.Find("LevelSelectPopup").gameObject.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}