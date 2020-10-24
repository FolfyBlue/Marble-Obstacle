using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDControl : MonoBehaviour
{
    public Button settingsBtn;
    public Button closeSettingsBtn;
    public Button closeGameBtn;
    public Toggle fullscreentgl;
    public bool isLevel;

    private GameObject settings;
    private bool fullscreen;

    // Start is called before the first frame update
    private void Start()
    {
        //SETTINGS SECTION
        settingsBtn.onClick.AddListener(SettingsPopup);
        closeSettingsBtn.onClick.AddListener(closeSettingsPopup);
        closeGameBtn.onClick.AddListener(exit);
        settings = transform.Find("Settings").gameObject;
        fullscreentgl.isOn = Screen.fullScreen;
        fullscreentgl.onValueChanged.AddListener((value) => fullscreenMode());
        settings.SetActive(false);
        /////
        // OTHER SECTION
        if (!isLevel)
        {
            transform.Find("Controls").gameObject.SetActive(false);
        }
    }

    private void exit()
    {
        if (isLevel)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
        else
        {
            Application.Quit();
        }
    }

    private void fullscreenMode()
    {
        Screen.fullScreen = !Screen.fullScreen;
        PlayerPrefs.SetInt("fullscreen", Screen.fullScreen ? 1 : 0);
        return;
    }

    private void closeSettingsPopup()
    {
        settings.SetActive(false);
        Time.timeScale = 1;
    }

    private void SettingsPopup()
    {
        settings.SetActive(true);
        Time.timeScale = 0;
        if (!isLevel)
        {
            closeGameBtn.transform.Find("Text").GetComponent<Text>().text = "Exit game";
            Time.timeScale = 1;
        }
        fullscreen = PlayerPrefs.GetInt("fullscreen") == 1;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}