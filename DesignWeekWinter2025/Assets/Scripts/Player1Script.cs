using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Script : MonoBehaviour
{
    // References to the Peasant and Werewolf GameObjects
    public GameObject peasant;
    public GameObject werewolf;

    // Flag to check if in Werewolf state
    private bool isWerewolf = false;

    // Reference to the InputActionAsset
    public InputActionAsset inputActions;

    private InputAction moveAction;

    // Start is called before the first frame update
    void Awake()
    {
        // Setup the input actions
        var playerActions = inputActions.FindActionMap("peasent");
        moveAction = playerActions.FindAction("Moving");

        werewolf.SetActive(false);
        peasant.SetActive(true);
    }

    // Enable the input actions
    private void OnEnable()
    {
        moveAction.Enable();
    }

    // Disable the input actions
    private void OnDisable()
    {
        moveAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isWerewolf)
        {
            werewolf.transform.position = peasant.transform.position;
        }
        else
        {
            peasant.transform.position = werewolf.transform.position; 
        }
    }

    public void ToggleTransformation()
    {
        if (isWerewolf)
        {
            // Transform back to peasant
            werewolf.SetActive(false);
            peasant.SetActive(true);
        }
        else
        {
            // Transform into werewolf
            peasant.SetActive(false);
            werewolf.SetActive(true);
        }

        // Toggle the state
        isWerewolf = !isWerewolf;
    }

    // Get the movement input vector
    public Vector2 GetMoveInput()
    {
        return moveAction.ReadValue<Vector2>();
    }
}
