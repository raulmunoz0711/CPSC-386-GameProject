using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    //Creates only 1 shared reference of AudioManagerScript
    public static AudioManagerScript Instance;
    public AudioSource musicSource;

    //Activates immediately as the scene loads
    private void Awake()
    {
        //if the audio exists already
        if (Instance == null)
        {
            //This is now the music
            Instance = this;
            //Lets music play even when scenes are switched
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destorys any other instance of AudioManagerScript
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //Plays music at the default volume (Max volume)
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);
        SetVolume(savedVolume);
    }

    public void SetVolume(float volume)
    {
        //Checks if music is assigned
        if (musicSource != null)
        {
            //Makes the music source volume and saves it on user system
            musicSource.volume = volume;
            PlayerPrefs.SetFloat("MusicVolume", volume);
        }
    }
}
