//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/ShipInput.inputactions
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

public partial class @ShipInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInput"",
    ""maps"": [
        {
            ""name"": ""Sailing"",
            ""id"": ""7e0b90b4-e707-4f7b-9c3e-31c3429eac65"",
            ""actions"": [
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Button"",
                    ""id"": ""52c7ad2f-5fce-4fbc-83d0-f53ebfeac824"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SlowDown"",
                    ""type"": ""Button"",
                    ""id"": ""7bb8ed95-8be4-4fad-ae94-ea82bdc36db6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""2559b608-a141-4942-91e8-285853463dd8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85d76dba-8778-4e5c-92ec-c06b8d6c2765"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbec6556-994e-41a2-b3f9-3e766c8f945f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fbfd6333-00ad-4534-9c7f-9ef4f4292ed5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""15843e86-1251-4bd0-b896-adfa9eca75c6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Sailing"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""55c0db34-b95a-4d87-96f6-1c88610826ed"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Sailing"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Sailing"",
            ""bindingGroup"": ""Sailing"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Sailing
        m_Sailing = asset.FindActionMap("Sailing", throwIfNotFound: true);
        m_Sailing_SpeedUp = m_Sailing.FindAction("SpeedUp", throwIfNotFound: true);
        m_Sailing_SlowDown = m_Sailing.FindAction("SlowDown", throwIfNotFound: true);
        m_Sailing_Steer = m_Sailing.FindAction("Steer", throwIfNotFound: true);
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

    // Sailing
    private readonly InputActionMap m_Sailing;
    private ISailingActions m_SailingActionsCallbackInterface;
    private readonly InputAction m_Sailing_SpeedUp;
    private readonly InputAction m_Sailing_SlowDown;
    private readonly InputAction m_Sailing_Steer;
    public struct SailingActions
    {
        private @ShipInput m_Wrapper;
        public SailingActions(@ShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpeedUp => m_Wrapper.m_Sailing_SpeedUp;
        public InputAction @SlowDown => m_Wrapper.m_Sailing_SlowDown;
        public InputAction @Steer => m_Wrapper.m_Sailing_Steer;
        public InputActionMap Get() { return m_Wrapper.m_Sailing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SailingActions set) { return set.Get(); }
        public void SetCallbacks(ISailingActions instance)
        {
            if (m_Wrapper.m_SailingActionsCallbackInterface != null)
            {
                @SpeedUp.started -= m_Wrapper.m_SailingActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.performed -= m_Wrapper.m_SailingActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.canceled -= m_Wrapper.m_SailingActionsCallbackInterface.OnSpeedUp;
                @SlowDown.started -= m_Wrapper.m_SailingActionsCallbackInterface.OnSlowDown;
                @SlowDown.performed -= m_Wrapper.m_SailingActionsCallbackInterface.OnSlowDown;
                @SlowDown.canceled -= m_Wrapper.m_SailingActionsCallbackInterface.OnSlowDown;
                @Steer.started -= m_Wrapper.m_SailingActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_SailingActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_SailingActionsCallbackInterface.OnSteer;
            }
            m_Wrapper.m_SailingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpeedUp.started += instance.OnSpeedUp;
                @SpeedUp.performed += instance.OnSpeedUp;
                @SpeedUp.canceled += instance.OnSpeedUp;
                @SlowDown.started += instance.OnSlowDown;
                @SlowDown.performed += instance.OnSlowDown;
                @SlowDown.canceled += instance.OnSlowDown;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
            }
        }
    }
    public SailingActions @Sailing => new SailingActions(this);
    private int m_SailingSchemeIndex = -1;
    public InputControlScheme SailingScheme
    {
        get
        {
            if (m_SailingSchemeIndex == -1) m_SailingSchemeIndex = asset.FindControlSchemeIndex("Sailing");
            return asset.controlSchemes[m_SailingSchemeIndex];
        }
    }
    public interface ISailingActions
    {
        void OnSpeedUp(InputAction.CallbackContext context);
        void OnSlowDown(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
    }
}
