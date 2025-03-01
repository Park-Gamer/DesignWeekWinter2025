using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P4WeakenedController : MonoBehaviour
{
    public float moveSpeed = 0.85f;  // Movement speed of the player

    private Rigidbody rb;  // Rigidbody of the player

    private Player4Script playerScript;
    AudioManager audioManager;
    public Animator anim;

    public FadeOut fade;

    void Start()
    {
        playerScript = FindAnyObjectByType<Player4Script>();
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
            audioManager.PlaySFX(audioManager.scream);
            fade.StartFade();
            Invoke("P1Victory", 4f);
        }
        if (collision.gameObject.CompareTag("Peasent2"))
        {
            audioManager.PlaySFX(audioManager.scream);
            fade.StartFade();
            Invoke("P2Victory", 4f);
        }
        if (collision.gameObject.CompareTag("Peasent3"))
        {
            audioManager.PlaySFX(audioManager.scream);
            fade.StartFade();
            Invoke("P3Victory", 4f);
        }
        if (collision.gameObject.CompareTag("Peasent4"))
        {
            audioManager.PlaySFX(audioManager.scream);
            fade.StartFade();
            Invoke("P4Victory", 4f);
        }
    }

    void P1Victory()
    {
        SceneManager.LoadScene("Peasant Winner");
    }
    void P2Victory()
    {
        SceneManager.LoadScene("PeasantP2Winner");
    }
    void P3Victory()
    {
        SceneManager.LoadScene("PeasantP3Winner");
    }
    void P4Victory()
    {
        SceneManager.LoadScene("PeasantP4Winner");
    }
}
