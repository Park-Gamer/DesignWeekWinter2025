using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4WeakenedController : MonoBehaviour
{
    public float moveSpeed = 0.85f;  // Movement speed of the player

    private Rigidbody rb;  // Rigidbody of the player

    private Player4Script playerScript;
    AudioManager audioManager;

    void Start()
    {
        playerScript = FindAnyObjectByType<Player4Script>();
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the player
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    void Update()
    {
        Vector2 move = playerScript.GetMoveInput();
        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(move.x, 0f, move.y).normalized;

        // Move the player
        MovePlayer(moveDirection);
    }

    void MovePlayer(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with another player
        if (collision.gameObject.CompareTag("Peasent"))
        {
            Debug.Log("P1PeasentWin");
        }
        if (collision.gameObject.CompareTag("Peasent2"))
        {
            Debug.Log("P2PeasentWin");
        }
        if (collision.gameObject.CompareTag("Peasent3"))
        {
            Debug.Log("P3PeasentWin");
        }
        if (collision.gameObject.CompareTag("Peasent4"))
        {
            Debug.Log("P4PeasentWin");
        }
    }
}
