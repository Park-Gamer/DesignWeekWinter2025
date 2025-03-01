using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ReadyCheck : MonoBehaviour
{
    private bool P1readyCheck = false;
    private bool P2readyCheck = false;
    private bool P3readyCheck = false;
    private bool P4readyCheck = false;
    private bool gameStart = false;

    public GameObject P1boarder;
    public GameObject P2boarder;
    public GameObject P3boarder;
    public GameObject P4boarder;

    public InputActionAsset inputActions;

    private InputAction P1moveAction;
    private InputAction P2moveAction;
    private InputAction P3moveAction;
    private InputAction P4moveAction;

    private Vector2 P1Moving;
    private Vector2 P2Moving;
    private Vector2 P3Moving;
    private Vector2 P4Moving;

    private AudioManager audioManager;
    public FadeOut fade;

    // Start is called before the first frame update
    void Awake()
    {
        // Setup the input actions
        var p1playerAction = inputActions.FindActionMap("peasent");
        P1moveAction = p1playerAction.FindAction("Moving");

        var p2playerAction = inputActions.FindActionMap("peasent2");
        P2moveAction = p2playerAction.FindAction("Moving");

        var p3playerAction = inputActions.FindActionMap("peasent3");
        P3moveAction = p3playerAction.FindAction("Moving");

        var p4playerAction = inputActions.FindActionMap("peasent4");
        P4moveAction = p4playerAction.FindAction("Moving");

        P1boarder.SetActive(false);
        P2boarder.SetActive(false);  
        P3boarder.SetActive(false);
        P4boarder.SetActive(false);

        audioManager = FindAnyObjectByType<AudioManager>();
    }
    private void OnEnable()
    {
        P1moveAction.Enable();
        P2moveAction.Enable();
        P3moveAction.Enable();
        P4moveAction.Enable();
    }

    // Disable the input actions
    private void OnDisable()
    {
        P1moveAction.Disable();
        P2moveAction.Disable();
        P3moveAction.Disable();
        P4moveAction.Disable();
    }

    private void Update()
    {
        P1Moving = P1moveAction.ReadValue<Vector2>();
        P2Moving = P2moveAction.ReadValue<Vector2>();
        P3Moving = P3moveAction.ReadValue<Vector2>();
        P4Moving = P4moveAction.ReadValue<Vector2>();

        if (P1Moving != Vector2.zero && !P1readyCheck)
        {
            audioManager.PlaySFX(audioManager.click);
            P1readyCheck = true;
            P1boarder.SetActive(true);
        }
        if (P2Moving != Vector2.zero && !P2readyCheck)
        {
            audioManager.PlaySFX(audioManager.click);
            P2readyCheck = true;
            P2boarder.SetActive(true);
        }
        if (P3Moving != Vector2.zero && !P3readyCheck)
        {
            audioManager.PlaySFX(audioManager.click);
            P3readyCheck = true;
            P3boarder.SetActive(true);
        }
        if (P4Moving != Vector2.zero && !P4readyCheck)
        {
            audioManager.PlaySFX(audioManager.click);
            P4readyCheck = true;
            P4boarder.SetActive(true);
        }

        if (P1readyCheck && P2readyCheck && P3readyCheck && P4readyCheck && !gameStart) 
        {
            gameStart = true;
            fade.StartFade();
            Invoke("SwitchToGameplay", 4f);
        }
    }

    void SwitchToGameplay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
