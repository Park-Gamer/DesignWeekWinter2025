//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/NewInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @NewInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInput"",
    ""maps"": [
        {
            ""name"": ""Werewolf"",
            ""id"": ""71d00cc7-5161-41a6-a44b-e4dde718a49e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5a0bcf17-d15e-4b69-9d71-210ed5be78e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5be4dbc7-7e44-450a-ada9-45de112a9c7b"",
                    ""path"": ""<DualSenseGamepadHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26867e77-1567-4a9e-a434-8cf638db9b13"",
                    ""path"": ""<DualSenseGamepadHID>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""peasent"",
            ""id"": ""19f0abb6-115c-4344-a826-5b0f9d476e4b"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""7616f851-8058-4f4a-9153-8ac83dd451f7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6b26c7a9-488b-4995-91ce-e4543608ed1a"",
                    ""path"": ""<SwitchProControllerHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Werewolf
        m_Werewolf = asset.FindActionMap("Werewolf", throwIfNotFound: true);
        m_Werewolf_Movement = m_Werewolf.FindAction("Movement", throwIfNotFound: true);
        // peasent
        m_peasent = asset.FindActionMap("peasent", throwIfNotFound: true);
        m_peasent_Moving = m_peasent.FindAction("Moving", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Werewolf
    private readonly InputActionMap m_Werewolf;
    private List<IWerewolfActions> m_WerewolfActionsCallbackInterfaces = new List<IWerewolfActions>();
    private readonly InputAction m_Werewolf_Movement;
    public struct WerewolfActions
    {
        private @NewInput m_Wrapper;
        public WerewolfActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Werewolf_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Werewolf; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WerewolfActions set) { return set.Get(); }
        public void AddCallbacks(IWerewolfActions instance)
        {
            if (instance == null || m_Wrapper.m_WerewolfActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WerewolfActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IWerewolfActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IWerewolfActions instance)
        {
            if (m_Wrapper.m_WerewolfActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWerewolfActions instance)
        {
            foreach (var item in m_Wrapper.m_WerewolfActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WerewolfActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WerewolfActions @Werewolf => new WerewolfActions(this);

    // peasent
    private readonly InputActionMap m_peasent;
    private List<IPeasentActions> m_PeasentActionsCallbackInterfaces = new List<IPeasentActions>();
    private readonly InputAction m_peasent_Moving;
    public struct PeasentActions
    {
        private @NewInput m_Wrapper;
        public PeasentActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_peasent_Moving;
        public InputActionMap Get() { return m_Wrapper.m_peasent; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PeasentActions set) { return set.Get(); }
        public void AddCallbacks(IPeasentActions instance)
        {
            if (instance == null || m_Wrapper.m_PeasentActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PeasentActionsCallbackInterfaces.Add(instance);
            @Moving.started += instance.OnMoving;
            @Moving.performed += instance.OnMoving;
            @Moving.canceled += instance.OnMoving;
        }

        private void UnregisterCallbacks(IPeasentActions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
        }

        public void RemoveCallbacks(IPeasentActions instance)
        {
            if (m_Wrapper.m_PeasentActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPeasentActions instance)
        {
            foreach (var item in m_Wrapper.m_PeasentActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PeasentActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PeasentActions @peasent => new PeasentActions(this);
    public interface IWerewolfActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPeasentActions
    {
        void OnMoving(InputAction.CallbackContext context);
    }
}
