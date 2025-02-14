using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WerewolfController : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float dashSpeed = 10f;  // Speed at which the player dashes
    public float dashDuration = 0.5f;  // How long the dash lasts
    public float dashCooldown = 0.1f;
    public LayerMask collisionLayer;  // Layer that represents the walls

    private bool isHowling;
    public float howlDuration = 0.5f;  // How long the dash lasts

    private Vector3 dashDirection;  // Direction in which the player will dash
    private bool canDash = true;  // Can the player dash
    private bool isDashing = false;
    private Rigidbody rb;  // Rigidbody for the player
    public int damageAmount = 10;  // How much health to subtract from the collided player
    public float rotationSpeed = 10f;

    private Vector2 move;
    private Vector2 dash;

    private Player1Script playerScript;
    private AudioManager audioManager;
    public Animator anim;
    private ScreenShake screenShake;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BeginHowl());

        playerScript = FindAnyObjectByType<Player1Script>();
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component
        audioManager = FindAnyObjectByType<AudioManager>();
        screenShake = FindAnyObjectByType<ScreenShake>();
        audioManager.PlaySFX(audioManager.werewolfHowl1);
        Debug.Log("switched");
    }

    void Update()
    {
        move = playerScript.GetMoveInput();
        dash = playerScript.GetDashInput();

        if (canDash && !isHowling)
        {
            // Round input to the nearest whole number to determine movement direction
            float roundedY = Mathf.Round(dash.y);
            float roundedX = Mathf.Round(dash.x);

            if (Mathf.Abs(roundedY) >= 0.9f || Mathf.Abs(roundedX) >= 0.9f)
            {
                // Determine the dash direction based on input
                if (roundedY == 1)
                {
                    dashDirection = Vector3.forward;  // Move forward
                }
                else if (roundedX == -1)
                {
                    dashDirection = Vector3.left;  // Move left
                }
                else if (roundedY == -1)
                {
                    dashDirection = Vector3.back;  // Move backward
                }
                else if (roundedX == 1)
                {
                    dashDirection = Vector3.right;  // Move right
                }

                transform.rotation = Quaternion.LookRotation(dashDirection);

                StartCoroutine(Dash());
            }
        }
        
        if (!isDashing && !isHowling)
        {
            // Calculate the movement direction
            Vector3 moveDirection = new Vector3(move.x, 0f, move.y).normalized;
            // Move the player
            MoveWerewolf(moveDirection);

            // Only rotate if there is some direction
            if (move.magnitude > 0)
            {
                anim.SetBool("IsMoving", true);
                // Calculate the angle in radians from the Vector2 (the direction vector)
                float angle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;

                // Smoothly rotate the player to the desired angle
                Quaternion targetRotation = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            else
            {
                anim.SetBool("IsMoving", false);
            }
        }
    }

    void MoveWerewolf(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }

    IEnumerator Dash()
    {
        anim.SetBool("IsDashing", true);
        isDashing = true;
        audioManager.PlaySFX(audioManager.werewolfDash);
        canDash = false;  // Prevent dashing until this dash ends

        // Dash the player in the desired direction
        float dashTime = 0f;
        while (dashTime < dashDuration)
        {
            // Raycast to check if we hit a wall ahead in the dash direction
            RaycastHit hit;
            if (Physics.Raycast(transform.position, dashDirection, out hit, 0.1f, collisionLayer))
            {
                // Stop the dash if we hit something
                audioManager.PlaySFX(audioManager.werewolfThud);
                screenShake.TriggerScreenShake();
                anim.SetBool("IsDashing", false);
                break;
            }

            // Move the player during the dash
            rb.MovePosition(transform.position + dashDirection * dashSpeed * Time.deltaTime);
    
            dashTime += Time.deltaTime;
            yield return null;
        }

        // Wait a bit before allowing another dash
        yield return new WaitForSeconds(dashCooldown);

        isDashing = false;
        anim.SetBool("IsDashing", false);
        canDash = true;  // Allow the player to dash again
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with another player
        if (collision.gameObject.CompareTag("Peasent"))
        {
            audioManager.PlaySFX(audioManager.werewolfChomp);
            Player1Controller p1HealthScript = collision.gameObject.GetComponent<Player1Controller>();
            p1HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent2"))
        {
            audioManager.PlaySFX(audioManager.werewolfChomp);
            Player2Controller p2HealthScript = collision.gameObject.GetComponent<Player2Controller>();
            p2HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent3"))
        {
            audioManager.PlaySFX(audioManager.werewolfChomp);
            Player3Controller p3HealthScript = collision.gameObject.GetComponent<Player3Controller>();
            p3HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent4"))
        {
            audioManager.PlaySFX(audioManager.werewolfChomp);
            Player4Controller p4HealthScript = collision.gameObject.GetComponent<Player4Controller>();
            p4HealthScript.ApplyDamage(damageAmount);
        }
    }

    IEnumerator BeginHowl()
    {
        isHowling = true;
        anim.SetBool("doneHowling", false);
        // Stop the player from moving on awake
        float howlTime = 0f;
        while (howlTime < howlDuration)
        {
            howlTime += Time.deltaTime;
        }
        // Wait a bit before allowing movement
        yield return new WaitForSeconds(howlDuration);

        isHowling = false;
        anim.SetBool("doneHowling", true);
    }
}
