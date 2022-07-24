using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioClip startSound;
    public AudioClip quitSound;
    private AudioSource menuAudio;

    // Start is called before the first frame update
    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        menuAudio.PlayOneShot(startSound, 1.0f);
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        menuAudio.PlayOneShot(quitSound, 1.0f);
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
