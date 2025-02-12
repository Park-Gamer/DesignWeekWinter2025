using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime = 0f;  // Timer duration in seconds
    private float timer;
    public float maxGameTime = 100f;
    public TextMeshProUGUI timerText;
    public TimerSlider timerSlider;

    private bool werewolfChosen = false;

    // Reference to the PlayerScript to trigger transformation
    public Player1Script P1playerScript;
    public Player2Script P2playerScript;
    public Player3Script P3playerScript;
    public Player4Script P4playerScript;

    void Start()
    {
        // Initialize the timer
        timer = gameTime;
        timerSlider.SetMaxTimer(maxGameTime);

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
        if (timer >= 2f && !werewolfChosen)
        {
            int selectedPlayer = 3;//Random.Range(1, 5);  // Random number between 1 and 4

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
    }
}
