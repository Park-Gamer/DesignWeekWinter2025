using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4Controller : MonoBehaviour
{
    public float moveSpeed = 1f;  // Movement speed of the player
    public int health = 30;
    public float invincibilityDuration = 2f; // Duration of invincibility in seconds
    private bool isInvincible = false; // If the player is invincible
    private float invincibilityTimer = 0f; // Timer for tracking invincibility duration

    private Rigidbody rb;  // Rigidbody of the player

    public bool isDead = false;
    public Animator anim;
    public GameObject bloodSplatter;

    private Player4Script playerScript;
    private AudioManager audioManager;
    private GameManager gameManager;

    public bool isTurning = false;
    private bool hasTurned = false;
    public float transformDuration = 3f;

    void Start()
    {
        playerScript = FindAnyObjectByType<Player4Script>();
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the player
        audioManager = FindAnyObjectByType<AudioManager>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        Vector2 move = playerScript.GetMoveInput();

        if (isTurning && !hasTurned)
        {
            hasTurned = true;
            StartCoroutine(BeginTurning());
        }

        if (!isDead && !isTurning)
        {
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
        audioManager.PlaySFX(audioManager.peasent4DeathSound);
        Debug.Log(gameObject.name + " has died.");
        isDead = true;
        anim.SetBool("isDead", true);
        gameManager.IncreaseDeathCount();
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
            audioManager.PlaySFX(audioManager.peasent2HurtSound);
            // If health drops to zero or below, call the death function
            if (health <= 0)
            {
                Die();
            }
            isInvincible = true;
            invincibilityTimer = invincibilityDuration;

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

    IEnumerator BeginTurning()
    {
        anim.SetBool("IsTurning", true);
        audioManager.PlaySFX(audioManager.werewolfStartDialog1);
        rb.velocity = Vector3.zero;
        // Stop the player from moving on awake
        float transformTime = 0f;
        while (transformTime < transformDuration)
        {
            transformTime += Time.deltaTime;
        }
        // Wait a bit before allowing movement
        yield return new WaitForSeconds(transformDuration);

        playerScript.ToggleTransformation();
    }
}
