using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public GameObject fadeOut;
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
        fadeOut.SetActive(false);
    }

    public void StartFade()
    {
        fadeOut.SetActive(true);
        audioManager.PlaySFX(audioManager.dun);
    }
}
