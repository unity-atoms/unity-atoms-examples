// GENERATED AUTOMATICALLY FROM 'Assets/Common/Input/DemoControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DemoControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DemoControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DemoControls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""35062ae5-10ae-466d-a7b9-0c5f472a2177"",
            ""actions"": [
                {
                    ""name"": ""ShootingUp"",
                    ""type"": ""Button"",
                    ""id"": ""8615d9fb-93b0-400c-9a4c-a39b681a4158"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootingDown"",
                    ""type"": ""Button"",
                    ""id"": ""e8aafec1-4a00-4799-a689-0a3539a1f366"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootingLeft"",
                    ""type"": ""Button"",
                    ""id"": ""8a55130d-5906-4c5d-a6d6-d07eba034237"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootingRight"",
                    ""type"": ""Button"",
                    ""id"": ""9c8b6bc1-5757-4974-8b43-87c5d3a87c22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Moving"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2fa85faf-2966-4a67-9329-4635ac11afc0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""47c8590a-3c81-4dea-afd6-b0a9d3c83605"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""82ae0eaa-eb7c-4add-a472-11116057a230"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""28c9cd27-13eb-4cda-8e92-b3c7fc01dd66"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b56720bd-3c31-4930-ae99-c97d4d9eafd0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""830e6dc2-9a81-494e-8cb9-ed45cf3f4ce8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5fbd74f7-a2e9-4925-bf3b-9a6671633b59"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootingDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00c3e6b4-8344-4337-9c83-359be513fab1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootingUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a11346b4-31ae-488a-abc2-afb9c363f7d9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootingRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e36175-01cb-4cf3-aa06-56945d7904cf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShootingLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_ShootingUp = m_InGame.FindAction("ShootingUp", throwIfNotFound: true);
        m_InGame_ShootingDown = m_InGame.FindAction("ShootingDown", throwIfNotFound: true);
        m_InGame_ShootingLeft = m_InGame.FindAction("ShootingLeft", throwIfNotFound: true);
        m_InGame_ShootingRight = m_InGame.FindAction("ShootingRight", throwIfNotFound: true);
        m_InGame_Moving = m_InGame.FindAction("Moving", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_ShootingUp;
    private readonly InputAction m_InGame_ShootingDown;
    private readonly InputAction m_InGame_ShootingLeft;
    private readonly InputAction m_InGame_ShootingRight;
    private readonly InputAction m_InGame_Moving;
    public struct InGameActions
    {
        private @DemoControls m_Wrapper;
        public InGameActions(@DemoControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootingUp => m_Wrapper.m_InGame_ShootingUp;
        public InputAction @ShootingDown => m_Wrapper.m_InGame_ShootingDown;
        public InputAction @ShootingLeft => m_Wrapper.m_InGame_ShootingLeft;
        public InputAction @ShootingRight => m_Wrapper.m_InGame_ShootingRight;
        public InputAction @Moving => m_Wrapper.m_InGame_Moving;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @ShootingUp.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingUp;
                @ShootingUp.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingUp;
                @ShootingUp.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingUp;
                @ShootingDown.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingDown;
                @ShootingDown.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingDown;
                @ShootingDown.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingDown;
                @ShootingLeft.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingLeft;
                @ShootingLeft.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingLeft;
                @ShootingLeft.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingLeft;
                @ShootingRight.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingRight;
                @ShootingRight.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingRight;
                @ShootingRight.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShootingRight;
                @Moving.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMoving;
                @Moving.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMoving;
                @Moving.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMoving;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShootingUp.started += instance.OnShootingUp;
                @ShootingUp.performed += instance.OnShootingUp;
                @ShootingUp.canceled += instance.OnShootingUp;
                @ShootingDown.started += instance.OnShootingDown;
                @ShootingDown.performed += instance.OnShootingDown;
                @ShootingDown.canceled += instance.OnShootingDown;
                @ShootingLeft.started += instance.OnShootingLeft;
                @ShootingLeft.performed += instance.OnShootingLeft;
                @ShootingLeft.canceled += instance.OnShootingLeft;
                @ShootingRight.started += instance.OnShootingRight;
                @ShootingRight.performed += instance.OnShootingRight;
                @ShootingRight.canceled += instance.OnShootingRight;
                @Moving.started += instance.OnMoving;
                @Moving.performed += instance.OnMoving;
                @Moving.canceled += instance.OnMoving;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IInGameActions
    {
        void OnShootingUp(InputAction.CallbackContext context);
        void OnShootingDown(InputAction.CallbackContext context);
        void OnShootingLeft(InputAction.CallbackContext context);
        void OnShootingRight(InputAction.CallbackContext context);
        void OnMoving(InputAction.CallbackContext context);
    }
}
