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

    public Player1Controller P1playerController;
    public Player2Controller P2playerController;
    public Player3Controller P3playerController;
    public Player4Controller P4playerController;

    void Start()
    {
        selectedPlayer = Random.Range(1, 5);
        // Initialize the timer
        timer = gameTime;
        timerSlider.SetMaxTimer(maxGameTime);

        audioManager = FindAnyObjectByType<AudioManager>();

        P1playerScript = FindAnyObjectByType<Player1Script>();
        P2playerScript = FindAnyObjectByType<Player2Script>();
        P3playerScript = FindAnyObjectByType<Player3Script>();
        P4playerScript = FindAnyObjectByType<Player4Script>();

        P1playerController = FindAnyObjectByType<Player1Controller>();
        P2playerController = FindAnyObjectByType<Player2Controller>();
        P3playerController = FindAnyObjectByType<Player3Controller>();
        P4playerController = FindAnyObjectByType<Player4Controller>();
    }

    void Update()
    {
        // Decrease the timer each frame
        timer += Time.deltaTime;
        timerSlider.SetTime(timer);

        // When the timer reaches 0, trigger the transformation
        if (timer >= 2f && !werewolfChosen)
        {
            if (selectedPlayer == 1)
            {
                P1playerController.isTurning = true;
            }
            else if (selectedPlayer == 2) 
            {
                P2playerController.isTurning = true;
            }
            else if (selectedPlayer == 3) 
            {
                P3playerController.isTurning = true;
            }
            else if (selectedPlayer == 4)
            {
                P4playerController.isTurning = true;
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
