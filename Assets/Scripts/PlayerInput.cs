// GENERATED AUTOMATICALLY FROM 'Assets/Prefabs/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""fa779b87-fdb5-436a-b2ab-335135a9b0d9"",
            ""actions"": [
                {
                    ""name"": ""StickRightX"",
                    ""type"": ""Value"",
                    ""id"": ""575625c1-0297-421c-a2d4-d10628509ebc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickRightY"",
                    ""type"": ""Value"",
                    ""id"": ""44e6e445-021b-4ab0-a01d-d39ce4605f83"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickLeftX"",
                    ""type"": ""Value"",
                    ""id"": ""e160f23b-ab24-47fd-9e0a-85193ce673ed"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickLeftY"",
                    ""type"": ""Value"",
                    ""id"": ""7635081f-b015-4493-8cdd-77052f18bf70"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45809f46-7bea-4cc9-8b1b-f1142d9a4230"",
                    ""path"": ""<HID::FrSky FrSky Taranis Joystick>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRightY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53aa046a-456b-4427-a846-b15e3c262fef"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRightY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fb62253-57ef-4542-8e8a-e2c66d810d6c"",
                    ""path"": ""<HID::FrSky FrSky Taranis Joystick>/rx"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickLeftX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57e8d2c5-ea19-443f-970b-4b8f47582749"",
                    ""path"": ""<HID::FrSky FrSky Taranis Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickLeftY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96a05942-06ad-4c4e-be21-b75868836183"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickLeftY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fed93273-5602-4bb1-90f2-05cf688167bc"",
                    ""path"": ""<HID::FrSky FrSky Taranis Joystick>/stick/y"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""StickRightX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93316586-6e55-4349-84b9-4cda96995123"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRightX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff9caa5e-a29a-4fef-85a0-615c04117623"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickLeftX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_StickRightX = m_Gameplay.FindAction("StickRightX", throwIfNotFound: true);
        m_Gameplay_StickRightY = m_Gameplay.FindAction("StickRightY", throwIfNotFound: true);
        m_Gameplay_StickLeftX = m_Gameplay.FindAction("StickLeftX", throwIfNotFound: true);
        m_Gameplay_StickLeftY = m_Gameplay.FindAction("StickLeftY", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_StickRightX;
    private readonly InputAction m_Gameplay_StickRightY;
    private readonly InputAction m_Gameplay_StickLeftX;
    private readonly InputAction m_Gameplay_StickLeftY;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @StickRightX => m_Wrapper.m_Gameplay_StickRightX;
        public InputAction @StickRightY => m_Wrapper.m_Gameplay_StickRightY;
        public InputAction @StickLeftX => m_Wrapper.m_Gameplay_StickLeftX;
        public InputAction @StickLeftY => m_Wrapper.m_Gameplay_StickLeftY;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @StickRightX.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightX;
                @StickRightX.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightX;
                @StickRightX.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightX;
                @StickRightY.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightY;
                @StickRightY.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightY;
                @StickRightY.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickRightY;
                @StickLeftX.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftX;
                @StickLeftX.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftX;
                @StickLeftX.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftX;
                @StickLeftY.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftY;
                @StickLeftY.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftY;
                @StickLeftY.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStickLeftY;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StickRightX.started += instance.OnStickRightX;
                @StickRightX.performed += instance.OnStickRightX;
                @StickRightX.canceled += instance.OnStickRightX;
                @StickRightY.started += instance.OnStickRightY;
                @StickRightY.performed += instance.OnStickRightY;
                @StickRightY.canceled += instance.OnStickRightY;
                @StickLeftX.started += instance.OnStickLeftX;
                @StickLeftX.performed += instance.OnStickLeftX;
                @StickLeftX.canceled += instance.OnStickLeftX;
                @StickLeftY.started += instance.OnStickLeftY;
                @StickLeftY.performed += instance.OnStickLeftY;
                @StickLeftY.canceled += instance.OnStickLeftY;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnStickRightX(InputAction.CallbackContext context);
        void OnStickRightY(InputAction.CallbackContext context);
        void OnStickLeftX(InputAction.CallbackContext context);
        void OnStickLeftY(InputAction.CallbackContext context);
    }
}
