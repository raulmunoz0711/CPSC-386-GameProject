using UnityEngine;
using UnityEngine.SceneManagement;

public class TextLogic : MonoBehaviour
{
    public GameObject LevelCompleteUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //UI stays hidden to start level
        LevelCompleteUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("Game2");
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void settingsScene()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
