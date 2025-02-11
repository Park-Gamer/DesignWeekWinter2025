using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the player
    private Rigidbody rb;  // Rigidbody of the player

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the player
    }

    void Update()
    {
        // Get input for movement (WASD or arrow keys)
        float horizontal = Input.GetAxisRaw("Horizontal");  // A/D or Left/Right Arrow keys
        float vertical = Input.GetAxisRaw("Vertical");  // W/S or Up/Down Arrow keys

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Move the player
        MovePlayer(moveDirection);
    }

    void MovePlayer(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }
}
