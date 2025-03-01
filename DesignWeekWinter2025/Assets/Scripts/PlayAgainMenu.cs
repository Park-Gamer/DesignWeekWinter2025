using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainMenu : MonoBehaviour
{
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
        audioManager.PlaySFX(audioManager.werewolfStartDialog1);
    }
    public void ReplayGame()
    {
        audioManager.PlaySFX(audioManager.click);
        Invoke("ReloadReadyCheck", 4f);
    }

    void ReloadReadyCheck()
    {
        SceneManager.LoadScene("ReadyCheck");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
