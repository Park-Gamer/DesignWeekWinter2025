using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2Controller : MonoBehaviour
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

    private Player2Script playerScript;

    void Awake()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    void Start()
    {
        playerScript = FindAnyObjectByType<Player2Script>();
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
        rb.velocity = direction * moveSpeed;  
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

            if (health <= 0)
            {
                Die();
            }
            isInvincible = true;
            invincibilityTimer = invincibilityDuration;

            playerRenderer.material.color = Color.red;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                Vector3 spawnPosition = hit.point;

                Quaternion spawnRotation = Quaternion.Euler(90f, 0f, 0f);
                Instantiate(bloodSplatter, spawnPosition, spawnRotation);
            }
        }
    }
}
