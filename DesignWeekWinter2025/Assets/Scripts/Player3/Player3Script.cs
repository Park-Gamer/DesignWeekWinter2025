using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player3Script : MonoBehaviour
{
    // References to the Peasant and Werewolf GameObjects
    public GameObject peasant;
    public GameObject werewolf;
    public GameObject weakenedHuman;

    // Flag to check if in Werewolf state
    private bool isWerewolf = false;
    private bool isWeakened = false;

    // Reference to the InputActionAsset
    public InputActionAsset inputActions;

    private InputAction moveAction;
    private InputAction dashAction;

    // Start is called before the first frame update
    void Awake()
    {
        // Setup the input actions
        var playerActions = inputActions.FindActionMap("peasent3");
        moveAction = playerActions.FindAction("Moving");
        dashAction = playerActions.FindAction("Dashing");

        werewolf.SetActive(false);
        weakenedHuman.SetActive(false);
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

    void Update()
    {
        if (!isWerewolf)
        {
            Vector3 positionOffset = new Vector3(peasant.transform.position.x, peasant.transform.position.y + 0.15f, peasant.transform.position.z);
            werewolf.transform.position = peasant.transform.position;
            weakenedHuman.transform.position = positionOffset;
        }
        else if (isWeakened)
        {
            werewolf.transform.position = weakenedHuman.transform.position;
            peasant.transform.position = weakenedHuman.transform.position;
        }
        else
        {
            Vector3 positionOffset = new Vector3(werewolf.transform.position.x, werewolf.transform.position.y, werewolf.transform.position.z);
            peasant.transform.position = werewolf.transform.position;
            weakenedHuman.transform.position = positionOffset;
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
    public void WeakenedTransformation()
    {
        werewolf.SetActive(false);
        weakenedHuman.SetActive(true);

        isWeakened = true;
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
