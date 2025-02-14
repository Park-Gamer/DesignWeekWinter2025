using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {

        Invoke("LoadReadyCheck", 4f);
    }

    void LoadReadyCheck()
    {
        SceneManager.LoadScene("ReadyCheck");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
