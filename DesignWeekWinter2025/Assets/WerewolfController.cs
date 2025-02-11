using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfController : MonoBehaviour
{
    public float dashSpeed = 10f;  // Speed at which the player dashes
    public float dashDuration = 0.5f;  // How long the dash lasts
    public float dashCooldown = 0.1f;
    public LayerMask collisionLayer;  // Layer that represents the walls

    private Vector3 dashDirection;  // Direction in which the player will dash
    private bool canDash = true;  // Can the player dash?
    private Rigidbody rb;  // Rigidbody for the player

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component
    }

    void Update()
    {
        if (canDash && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)))
        {
            // Get dash direction based on input
            if (Input.GetKeyDown(KeyCode.W))
                dashDirection = Vector3.forward;
            else if (Input.GetKeyDown(KeyCode.A))
                dashDirection = Vector3.left;
            else if (Input.GetKeyDown(KeyCode.S))
                dashDirection = Vector3.back;
            else if (Input.GetKeyDown(KeyCode.D))
                dashDirection = Vector3.right;

            StartCoroutine(Dash());
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
}
