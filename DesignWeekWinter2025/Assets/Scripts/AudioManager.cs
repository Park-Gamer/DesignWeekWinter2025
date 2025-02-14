using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------- Audio Clips -----------")]
    public AudioClip backgroundMusic;

    public AudioClip peasent1HurtSound;
    public AudioClip peasent2HurtSound;
    public AudioClip peasent1DeathSound;
    public AudioClip peasent2DeathSound;
    public AudioClip peasent3DeathSound;
    public AudioClip peasent4DeathSound;
    public AudioClip peasentVictory1;

    public AudioClip scream;

    public AudioClip werewolfChomp;
    public AudioClip werewolfDash;
    public AudioClip werewolfThud;
    public AudioClip werewolfStartDialog1;
    public AudioClip werewolfStartDialog2;
    public AudioClip werewolfStartDialog3;
    public AudioClip werewolfHowl1;

    public AudioClip click;
    public AudioClip dun;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
