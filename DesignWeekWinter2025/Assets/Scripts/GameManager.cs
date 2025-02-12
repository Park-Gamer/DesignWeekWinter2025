using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime = 0f;  // Timer duration in seconds
    private float timer;
    public TextMeshProUGUI timerText;

    private bool werewolfChosen = false;

    // Reference to the PlayerScript to trigger transformation
    public Player1Script playerScript;

    void Start()
    {
        // Initialize the timer
        timer = gameTime;

        playerScript = FindAnyObjectByType<Player1Script>();
    }

    void Update()
    {
        // Decrease the timer each frame
        timer += Time.deltaTime;
        timerText.text = "Game Time: " + Mathf.Ceil(timer).ToString();

        // When the timer reaches 0, trigger the transformation
        if (timer >= 10f && !werewolfChosen)
        {
            werewolfChosen = true;
            // Trigger the transformation (from the PlayerScript)
            playerScript.ToggleTransformation();
        }
    }
}
