using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P3WerewolfController : MonoBehaviour
{
    public float moveSpeed = 0.7f;
    public float dashSpeed = 10f;  // Speed at which the player dashes
    public float dashDuration = 1f;  // How long the dash lasts
    public float dashCooldown = 0.1f;
    public LayerMask collisionLayer;  // Layer that represents the walls

    private Vector3 dashDirection;  // Direction in which the player will dash
    private bool canDash = true;  // Can the player dash
    private bool isDashing = false;
    private Rigidbody rb;  // Rigidbody for the player
    public int damageAmount = 10;  // How much health to subtract from the collided player

    private Vector2 move;
    private Vector2 dash;

    private Player3Script playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindAnyObjectByType<Player3Script>();
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component

        Debug.Log("P3switched");
    }

    void Update()
    {
        move = playerScript.GetMoveInput();
        dash = playerScript.GetDashInput();

        if (canDash)
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

                StartCoroutine(Dash());
            }
        }

        if (!isDashing)
        {
            // Calculate the movement direction
            Vector3 moveDirection = new Vector3(move.x, 0f, move.y).normalized;

            // Move the player
            MoveWerewolf(moveDirection);
        }
    }

    void MoveWerewolf(Vector3 direction)
    {
        // Apply the movement to the Rigidbody
        rb.velocity = direction * moveSpeed;  // Move the player based on the input direction and speed
    }

    IEnumerator Dash()
    {
        isDashing = true;
        canDash = false;  // Prevent dashing until this dash ends

        // Dash the player in the desired direction
        float dashTime = 0f;
        while (dashTime < dashDuration)
        {
            // Raycast to check if we hit a wall ahead in the dash direction
            RaycastHit hit;
            if (Physics.Raycast(transform.position, dashDirection, out hit, dashSpeed * Time.deltaTime, collisionLayer))
            {
                // Stop the dash if we hit something
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
        canDash = true;  // Allow the player to dash again
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with another player
        if (collision.gameObject.CompareTag("Peasent"))
        {
            Player1Controller p1HealthScript = collision.gameObject.GetComponent<Player1Controller>();
            p1HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent2"))
        {
            Player2Controller p2HealthScript = collision.gameObject.GetComponent<Player2Controller>();
            p2HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent3"))
        {
            Player3Controller p3HealthScript = collision.gameObject.GetComponent<Player3Controller>();
            p3HealthScript.ApplyDamage(damageAmount);
        }
        if (collision.gameObject.CompareTag("Peasent4"))
        {
            Player4Controller p4HealthScript = collision.gameObject.GetComponent<Player4Controller>();
            p4HealthScript.ApplyDamage(damageAmount);
        }
    }
}
