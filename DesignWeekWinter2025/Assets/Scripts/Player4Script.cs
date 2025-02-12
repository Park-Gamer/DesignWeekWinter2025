using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player4Script : MonoBehaviour
{
    // References to the Peasant and Werewolf GameObjects
    public GameObject peasant;
    public GameObject werewolf;

    // Flag to check if in Werewolf state
    private bool isWerewolf = false;

    // Reference to the InputActionAsset
    public InputActionAsset inputActions;

    private InputAction moveAction;
    private InputAction dashAction;

    // Start is called before the first frame update
    void Awake()
    {
        // Setup the input actions
        var playerActions = inputActions.FindActionMap("peasent4");
        moveAction = playerActions.FindAction("Moving");
        dashAction = playerActions.FindAction("Dashing");

        werewolf.SetActive(false);
        peasant.SetActive(true);
    }

    // Enable the input actions
    private void OnEnable()
    {
        moveAction.Enable();
        dashAction.Enable();
    }

    // Disable the input actions
    private void OnDisable()
    {
        moveAction.Disable();
        dashAction.Disable();
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
    public Vector2 GetDashInput()
    {
        return dashAction.ReadValue<Vector2>();
    }
}
