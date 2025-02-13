using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime = 0f;  // Timer duration in seconds
    private float timer;
    public float maxGameTime = 5f;
    public bool timerEnded = false;
    public int numPlayerDeath = 0;
    public TextMeshProUGUI timerText;
    public TimerSlider timerSlider;

    public int selectedPlayer;
    private bool werewolfChosen = false;

    private AudioManager audioManager;

    // Reference to the PlayerScript to trigger transformation
    public Player1Script P1playerScript;
    public Player2Script P2playerScript;
    public Player3Script P3playerScript;
    public Player4Script P4playerScript;

    void Start()
    {
        selectedPlayer = 4;//Random.Range(1, 5);
        // Initialize the timer
        timer = gameTime;
        timerSlider.SetMaxTimer(maxGameTime);

        audioManager = FindAnyObjectByType<AudioManager>();
        P1playerScript = FindAnyObjectByType<Player1Script>();
        P2playerScript = FindAnyObjectByType<Player2Script>();
        P3playerScript = FindAnyObjectByType<Player3Script>();
        P4playerScript = FindAnyObjectByType<Player4Script>();
    }

    void Update()
    {
        // Decrease the timer each frame
        timer += Time.deltaTime;
        timerSlider.SetTime(timer);

        // When the timer reaches 0, trigger the transformation
        if (timer >= 10f && !werewolfChosen)
        {
            if (selectedPlayer == 1)
            {
                P1playerScript.ToggleTransformation();
            }
            else if (selectedPlayer == 2) 
            {
                P2playerScript.ToggleTransformation();
            }
            else if (selectedPlayer == 3) 
            {
                P3playerScript.ToggleTransformation();
            }
            else if (selectedPlayer == 4)
            {
                P4playerScript.ToggleTransformation();
            }
            werewolfChosen = true;
        }

        if (timer >= maxGameTime && !timerEnded)
        {
            timerEnded = true;
            audioManager.PlaySFX(audioManager.peasentVictory1);
            if (selectedPlayer == 1)
            {
                P1playerScript.WeakenedTransformation();
            }
            else if (selectedPlayer == 2)
            {
                P2playerScript.WeakenedTransformation();
            }
            else if (selectedPlayer == 3)
            {
                P3playerScript.WeakenedTransformation();
            }
            else if (selectedPlayer == 4)
            {
                P4playerScript.WeakenedTransformation();
            }
        }

        if(numPlayerDeath >= 3)
        {
            Debug.Log("Werewolf wins");
        }
    }

    public void IncreaseDeathCount()
    {
        numPlayerDeath++;
    }
    public void DecreaseDeathCount()
    {
        numPlayerDeath--;
    }
}
