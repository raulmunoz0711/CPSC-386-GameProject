using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManagerScript : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        //Looks for saved MusicVolume and if not found then returns default volume (Highest volume)
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);
        //slider matches saved volume
        volumeSlider.value = savedVolume;
    }

    public void OnVolumeChanged(float value)
    {
        //Checks if AudioManager exists
        if (AudioManagerScript.Instance != null)
        {
            //Updates music volume
            AudioManagerScript.Instance.SetVolume(value);   
        }

    }
    //Makes button return to "Main Menu" scene
    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void quitGame()
    {
        //Allows user to quit game
        Application.Quit();
        Debug.Log("User Quit Game");
    }
}
