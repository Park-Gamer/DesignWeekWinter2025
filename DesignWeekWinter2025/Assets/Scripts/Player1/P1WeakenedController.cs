using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1WeakenedController : MonoBehaviour
{
    public float moveSpeed = 0.85f;  // Movement speed of the player

    private Rigidbody rb;  // Rigidbody of the player

    public Player1Script playerScript;
    AudioManager audioManager;
    public Animator anim;

    void Start()
    {
        playerScript = FindAnyObjectByType<Player1Script>();
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

        // Only rotate if there is some direction
        if (move.magnitude > 0)
        {
            anim.SetBool("IsMoving", true);
            // Calculate the angle in radians from the Vector2 (the direction vector)
            float angle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;

            // Smoothly rotate the player to the desired angle
            Quaternion targetRotation = Quaternion.Euler(0, angle, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }
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
