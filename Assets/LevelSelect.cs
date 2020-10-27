using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    //private List<Button> levels;

    private void Awake()
    {
        var levelObj = transform.Find("Levels");
        foreach (Transform level in levelObj)
        {
            var levelNumber = int.Parse(level.gameObject.name);
            level.gameObject.GetComponent<Button>().onClick.AddListener(() => gotoLevel(levelNumber));
        }
    }

    private void gotoLevel(int level)
    {
        Debug.Log("Accessing level " + level);
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}