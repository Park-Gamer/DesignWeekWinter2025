using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
    }
    public void PlayGame ()
    {
        SceneManager.LoadScene("ReadyCheck");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
