using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Controller : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the player
    private Rigidbody rb;  // Rigidbody of the player

    private Vector2 move;
    NewInput playerControls;

    public float health = 100f;  // Starting health
    private bool isDead = false;
    public Animator anim;

    void Awake()
    {
        playerControls = new NewInput();

        playerControls.peasent.Moving.performed += ctx => move = ctx.ReadValue<Vector2>();
        playerControls.peasent.Moving.canceled += ctx => move = Vector2.zero;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the player
    }

    void Update()
    {
        if (!isDead)
        {
            // Calculate the movement direction
            Vector3 moveDirection = new Vector3(move.x, 0f, move.y).normalized;

            // Move the player
            MovePlayer(moveDirection);
        }
    }

    void MovePlayer(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log(gameObject.name + " Health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log(gameObject.name + " has died.");
        isDead = true;
        anim.SetBool("isDead", true);
    }

    void OnEnable()
    {
        playerControls.peasent.Enable();
    }

    void OnDisable()
    {
        playerControls.peasent.Disable();
    }
}
