using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject button;
    private AudioManager audioManager;

    private bool fadeStart = false;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
        fadeOut.SetActive(false);
    }

    public void StartFade()
    {
        if (!fadeStart)
        {
            fadeStart = true;
            fadeOut.SetActive(true);
            audioManager.PlaySFX(audioManager.dun);
        }
    }

    public void DisableButton()
    {
        button.SetActive(false);
    }

}
