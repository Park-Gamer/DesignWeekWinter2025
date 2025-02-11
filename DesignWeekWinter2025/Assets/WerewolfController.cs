using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WerewolfController : MonoBehaviour
{
    public float dashSpeed = 10f;  // Speed at which the player dashes
    public float dashDuration = 0.5f;  // How long the dash lasts
    public float dashCooldown = 0.1f;
    public LayerMask collisionLayer;  // Layer that represents the walls

    private Vector3 dashDirection;  // Direction in which the player will dash
    private bool canDash = true;  // Can the player dash?
    private Rigidbody rb;  // Rigidbody for the player
    public float damageAmount = 10f;  // How much health to subtract from the collided player

    private Vector2 move;
    NewInput controls;

    void Awake()
    {
        controls = new NewInput();

        controls.Werewolf.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Werewolf.Movement.canceled += ctx => move = Vector2.zero;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component
    }

    void Update()
    {
        if (canDash)
        {
            // Round input to the nearest whole number to determine movement direction
            float roundedY = Mathf.Round(move.y);
            float roundedX = Mathf.Round(move.x);

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
    }

    IEnumerator Dash()
    {
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

        canDash = true;  // Allow the player to dash again
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with another player
        if (collision.gameObject.CompareTag("Peasent"))
        {
            // Attempt to find the PlayerHealth component on the collided player
            Player1Controller playerHealth = collision.gameObject.GetComponent<Player1Controller>();

            // If the collided player has a PlayerHealth script attached, lower their health
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
            else
            {
                Debug.LogWarning("No PlayerHealth script found on collided player!");
            }
        }
    }

        void OnEnable()
    {
        controls.Werewolf.Enable();
    }

    void OnDisable()
    {
        controls.Werewolf.Disable();
    }
}
