using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Controller : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the player
    public int health = 100;
    public float invincibilityDuration = 5f; // Duration of invincibility in seconds
    private bool isInvincible = false; // If the player is invincible
    private float invincibilityTimer = 0f; // Timer for tracking invincibility duration

    private Renderer playerRenderer; // For visual effect 
    public Color originalColor = new Color(1f, 0.5f, 0f);
    private Rigidbody rb;  // Rigidbody of the player

    public bool isDead = false;
    public Animator anim;
    //public GameObject blood;
    public GameObject bloodSplatter;

    private Player1Script playerScript;

    void Awake()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    void Start()
    {
        playerScript = FindAnyObjectByType<Player1Script>();
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the player
    }

    void Update()
    {
        Vector2 move = playerScript.GetMoveInput();

        if (!isDead)
        {
            // Calculate the movement direction
            Vector3 moveDirection = new Vector3(move.x, 0f, move.y).normalized;

            // Move the player
            MovePlayer(moveDirection);

            if (isInvincible)
            {
                invincibilityTimer -= Time.deltaTime;

                if (invincibilityTimer <= 0f)
                {
                    // End invincibility after the duration
                    isInvincible = false;
                    playerRenderer.material.color = originalColor;
                }
            }
        }
    }

    void MovePlayer(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }

    public void Die()
    {
        Debug.Log(gameObject.name + " has died.");
        isDead = true;
        anim.SetBool("isDead", true);
    }

    public void ApplyDamage(int damage)
    {
        if (!isDead)
        {
            if (isInvincible)
            {
                return;
            }
            health -= damage;
            //Instantiate(blood, transform.position, Quaternion.identity);
            // If health drops to zero or below, call the death function
            if (health <= 0)
            {
                Die();
            }
            isInvincible = true;
            invincibilityTimer = invincibilityDuration;

            // Visual effect: Change player color to red during invincibility (optional)
            playerRenderer.material.color = Color.red;
        
            // Raycast to the ground to find the floor's normal
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                // Instantiate blood splatter at the floor's hit point
                Vector3 spawnPosition = hit.point;

                Quaternion spawnRotation = Quaternion.Euler(90f, 0f, 0f);
                Instantiate(bloodSplatter, spawnPosition, spawnRotation);
            }
        }
    }
}
