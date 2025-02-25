//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/NewInput.inputactions
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
                },
                {
                    ""name"": ""Dashing"",
                    ""type"": ""Value"",
                    ""id"": ""e56b7c1f-5218-4e11-858c-fb58fc38ec71"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""743c5984-7340-4b66-8556-ce9cb1a6c758"",
                    ""path"": ""<SwitchProControllerHID>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906af138-fe7b-4bfa-8be7-e7f4e3b724a1"",
                    ""path"": ""<SwitchProControllerHID>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""peasent2"",
            ""id"": ""28c7d64a-24ea-436a-8554-74ce52b2a0c7"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""56d14c37-c878-46e8-86c5-2d2d0ba7aa3e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dashing"",
                    ""type"": ""Value"",
                    ""id"": ""a2ca8ad9-98a8-457b-9c1e-1505ab178a93"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ec6ab2d-397b-45b0-8406-779b3c04a0a2"",
                    ""path"": ""<DualSenseGamepadHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2156b62d-2b87-496d-9ccc-10cd74a4f119"",
                    ""path"": ""<DualSenseGamepadHID>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc9c8918-f635-431c-8578-d42d6d019c62"",
                    ""path"": ""<DualSenseGamepadHID>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Werewolf"",
            ""id"": ""716815c8-3d6c-4c54-a338-19ff9f4a29d1"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""33e5d134-aab0-44aa-a810-667dff45e8e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6fd68e6-9055-4a05-9ead-c7015389f1d0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""peasent3"",
            ""id"": ""4bb50a64-d55c-4a24-a408-a0d15747c206"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""fb8efcae-b51f-461e-8448-f523d320aa53"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dashing"",
                    ""type"": ""Value"",
                    ""id"": ""c04e077f-59f2-499d-bcf7-f0f49df27908"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1d87d7ba-1d47-49fb-a35e-b5529c0ca18c"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56d5bbaf-b0fa-4e3a-b110-27cefbbc0523"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bbf2873-ff7e-4eb3-a09f-059353c72c93"",
                    ""path"": ""<XInputController>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""peasent4"",
            ""id"": ""f046e1dd-6eb3-46c8-9b88-93429f5b578e"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""6635ed92-37dd-42e4-a734-cfb7172291a7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dashing"",
                    ""type"": ""Value"",
                    ""id"": ""c8b42804-d849-48f3-9b18-a5ee935f85fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4d592ee9-7955-4426-abbf-3fdff6ac7777"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dfed573-6754-46dc-bf42-c6d69eafabe6"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // peasent
        m_peasent = asset.FindActionMap("peasent", throwIfNotFound: true);
        m_peasent_Moving = m_peasent.FindAction("Moving", throwIfNotFound: true);
        m_peasent_Dashing = m_peasent.FindAction("Dashing", throwIfNotFound: true);
        // peasent2
        m_peasent2 = asset.FindActionMap("peasent2", throwIfNotFound: true);
        m_peasent2_Moving = m_peasent2.FindAction("Moving", throwIfNotFound: true);
        m_peasent2_Dashing = m_peasent2.FindAction("Dashing", throwIfNotFound: true);
        // Werewolf
        m_Werewolf = asset.FindActionMap("Werewolf", throwIfNotFound: true);
        m_Werewolf_Newaction = m_Werewolf.FindAction("New action", throwIfNotFound: true);
        // peasent3
        m_peasent3 = asset.FindActionMap("peasent3", throwIfNotFound: true);
        m_peasent3_Moving = m_peasent3.FindAction("Moving", throwIfNotFound: true);
        m_peasent3_Dashing = m_peasent3.FindAction("Dashing", throwIfNotFound: true);
        // peasent4
        m_peasent4 = asset.FindActionMap("peasent4", throwIfNotFound: true);
        m_peasent4_Moving = m_peasent4.FindAction("Moving", throwIfNotFound: true);
        m_peasent4_Dashing = m_peasent4.FindAction("Dashing", throwIfNotFound: true);
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

    // peasent
    private readonly InputActionMap m_peasent;
    private List<IPeasentActions> m_PeasentActionsCallbackInterfaces = new List<IPeasentActions>();
    private readonly InputAction m_peasent_Moving;
    private readonly InputAction m_peasent_Dashing;
    public struct PeasentActions
    {
        private @NewInput m_Wrapper;
        public PeasentActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_peasent_Moving;
        public InputAction @Dashing => m_Wrapper.m_peasent_Dashing;
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
            @Dashing.started += instance.OnDashing;
            @Dashing.performed += instance.OnDashing;
            @Dashing.canceled += instance.OnDashing;
        }

        private void UnregisterCallbacks(IPeasentActions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
            @Dashing.started -= instance.OnDashing;
            @Dashing.performed -= instance.OnDashing;
            @Dashing.canceled -= instance.OnDashing;
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

    // peasent2
    private readonly InputActionMap m_peasent2;
    private List<IPeasent2Actions> m_Peasent2ActionsCallbackInterfaces = new List<IPeasent2Actions>();
    private readonly InputAction m_peasent2_Moving;
    private readonly InputAction m_peasent2_Dashing;
    public struct Peasent2Actions
    {
        private @NewInput m_Wrapper;
        public Peasent2Actions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_peasent2_Moving;
        public InputAction @Dashing => m_Wrapper.m_peasent2_Dashing;
        public InputActionMap Get() { return m_Wrapper.m_peasent2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Peasent2Actions set) { return set.Get(); }
        public void AddCallbacks(IPeasent2Actions instance)
        {
            if (instance == null || m_Wrapper.m_Peasent2ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Peasent2ActionsCallbackInterfaces.Add(instance);
            @Moving.started += instance.OnMoving;
            @Moving.performed += instance.OnMoving;
            @Moving.canceled += instance.OnMoving;
            @Dashing.started += instance.OnDashing;
            @Dashing.performed += instance.OnDashing;
            @Dashing.canceled += instance.OnDashing;
        }

        private void UnregisterCallbacks(IPeasent2Actions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
            @Dashing.started -= instance.OnDashing;
            @Dashing.performed -= instance.OnDashing;
            @Dashing.canceled -= instance.OnDashing;
        }

        public void RemoveCallbacks(IPeasent2Actions instance)
        {
            if (m_Wrapper.m_Peasent2ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPeasent2Actions instance)
        {
            foreach (var item in m_Wrapper.m_Peasent2ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Peasent2ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Peasent2Actions @peasent2 => new Peasent2Actions(this);

    // Werewolf
    private readonly InputActionMap m_Werewolf;
    private List<IWerewolfActions> m_WerewolfActionsCallbackInterfaces = new List<IWerewolfActions>();
    private readonly InputAction m_Werewolf_Newaction;
    public struct WerewolfActions
    {
        private @NewInput m_Wrapper;
        public WerewolfActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Werewolf_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Werewolf; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WerewolfActions set) { return set.Get(); }
        public void AddCallbacks(IWerewolfActions instance)
        {
            if (instance == null || m_Wrapper.m_WerewolfActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WerewolfActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IWerewolfActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
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

    // peasent3
    private readonly InputActionMap m_peasent3;
    private List<IPeasent3Actions> m_Peasent3ActionsCallbackInterfaces = new List<IPeasent3Actions>();
    private readonly InputAction m_peasent3_Moving;
    private readonly InputAction m_peasent3_Dashing;
    public struct Peasent3Actions
    {
        private @NewInput m_Wrapper;
        public Peasent3Actions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_peasent3_Moving;
        public InputAction @Dashing => m_Wrapper.m_peasent3_Dashing;
        public InputActionMap Get() { return m_Wrapper.m_peasent3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Peasent3Actions set) { return set.Get(); }
        public void AddCallbacks(IPeasent3Actions instance)
        {
            if (instance == null || m_Wrapper.m_Peasent3ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Peasent3ActionsCallbackInterfaces.Add(instance);
            @Moving.started += instance.OnMoving;
            @Moving.performed += instance.OnMoving;
            @Moving.canceled += instance.OnMoving;
            @Dashing.started += instance.OnDashing;
            @Dashing.performed += instance.OnDashing;
            @Dashing.canceled += instance.OnDashing;
        }

        private void UnregisterCallbacks(IPeasent3Actions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
            @Dashing.started -= instance.OnDashing;
            @Dashing.performed -= instance.OnDashing;
            @Dashing.canceled -= instance.OnDashing;
        }

        public void RemoveCallbacks(IPeasent3Actions instance)
        {
            if (m_Wrapper.m_Peasent3ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPeasent3Actions instance)
        {
            foreach (var item in m_Wrapper.m_Peasent3ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Peasent3ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Peasent3Actions @peasent3 => new Peasent3Actions(this);

    // peasent4
    private readonly InputActionMap m_peasent4;
    private List<IPeasent4Actions> m_Peasent4ActionsCallbackInterfaces = new List<IPeasent4Actions>();
    private readonly InputAction m_peasent4_Moving;
    private readonly InputAction m_peasent4_Dashing;
    public struct Peasent4Actions
    {
        private @NewInput m_Wrapper;
        public Peasent4Actions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_peasent4_Moving;
        public InputAction @Dashing => m_Wrapper.m_peasent4_Dashing;
        public InputActionMap Get() { return m_Wrapper.m_peasent4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Peasent4Actions set) { return set.Get(); }
        public void AddCallbacks(IPeasent4Actions instance)
        {
            if (instance == null || m_Wrapper.m_Peasent4ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Peasent4ActionsCallbackInterfaces.Add(instance);
            @Moving.started += instance.OnMoving;
            @Moving.performed += instance.OnMoving;
            @Moving.canceled += instance.OnMoving;
            @Dashing.started += instance.OnDashing;
            @Dashing.performed += instance.OnDashing;
            @Dashing.canceled += instance.OnDashing;
        }

        private void UnregisterCallbacks(IPeasent4Actions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
            @Dashing.started -= instance.OnDashing;
            @Dashing.performed -= instance.OnDashing;
            @Dashing.canceled -= instance.OnDashing;
        }

        public void RemoveCallbacks(IPeasent4Actions instance)
        {
            if (m_Wrapper.m_Peasent4ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPeasent4Actions instance)
        {
            foreach (var item in m_Wrapper.m_Peasent4ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Peasent4ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Peasent4Actions @peasent4 => new Peasent4Actions(this);
    public interface IPeasentActions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnDashing(InputAction.CallbackContext context);
    }
    public interface IPeasent2Actions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnDashing(InputAction.CallbackContext context);
    }
    public interface IWerewolfActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IPeasent3Actions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnDashing(InputAction.CallbackContext context);
    }
    public interface IPeasent4Actions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnDashing(InputAction.CallbackContext context);
    }
}
