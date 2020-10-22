using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Button restartBtn;
    public Button endBtn;
    public Button nextBtn;

    // Start is called before the first frame update
    private void Start()
    {
        restartBtn.onClick.AddListener(restart);
        nextBtn.onClick.AddListener(next);
        endBtn.onClick.AddListener(end);
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void end()
    {
        SceneManager.LoadScene(0);
    }

    public void trigger()
    {
        PlayerPrefs.DeleteAll();
        this.gameObject.SetActive(true);
        PlayerPrefs.SetInt("curLvl", SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}