// GENERATED AUTOMATICALLY FROM 'Assets/GameAssets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""48cb9c3e-8ec1-4cc0-8c30-ce8a6a3ee888"",
            ""actions"": [
                {
                    ""name"": ""InputMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8e2a6678-de8b-4242-a856-da9ba7b9c974"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputJump"",
                    ""type"": ""Button"",
                    ""id"": ""7aa2f351-b4be-47fe-869b-d578d52e7370"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputAbility"",
                    ""type"": ""Button"",
                    ""id"": ""6ece0954-3413-4ea1-805b-4deea4645634"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputSuicide"",
                    ""type"": ""Button"",
                    ""id"": ""8d0ebae8-91c0-432d-a1e2-d6e11cc342ae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputInteract"",
                    ""type"": ""Button"",
                    ""id"": ""2012566c-adca-4c27-ad90-1177ac1563bc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyboardMoveInput"",
                    ""id"": ""5a55a5a0-5356-4db0-b509-df0fc2889813"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""628eac4b-7924-4bba-b164-6483f1e15230"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b36067af-a406-4a84-bad5-13f36867cedb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""07e1944f-e9f7-44a8-afaa-d117f8ad52f0"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7d266ce-87c8-4ed5-973a-a1240503c555"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""627c7652-973b-435f-95f6-ee289e30cb4d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f5b7c14-1f77-4c6c-804f-5cc39102ffd9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33cb9580-2032-45d8-9cc2-9346c67d1b8f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4312718c-211c-4a60-b5b6-284e22b1ac34"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputSuicide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a49a9243-fefb-4049-ad54-0f84d082f256"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputSuicide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ce60805-333e-4d18-9e23-4ca559fad1bd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03d53311-3bff-4069-bca2-3707ef834ed3"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_InputMove = m_PlayerControls.FindAction("InputMove", throwIfNotFound: true);
        m_PlayerControls_InputJump = m_PlayerControls.FindAction("InputJump", throwIfNotFound: true);
        m_PlayerControls_InputAbility = m_PlayerControls.FindAction("InputAbility", throwIfNotFound: true);
        m_PlayerControls_InputSuicide = m_PlayerControls.FindAction("InputSuicide", throwIfNotFound: true);
        m_PlayerControls_InputInteract = m_PlayerControls.FindAction("InputInteract", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_InputMove;
    private readonly InputAction m_PlayerControls_InputJump;
    private readonly InputAction m_PlayerControls_InputAbility;
    private readonly InputAction m_PlayerControls_InputSuicide;
    private readonly InputAction m_PlayerControls_InputInteract;
    public struct PlayerControlsActions
    {
        private @Controls m_Wrapper;
        public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputMove => m_Wrapper.m_PlayerControls_InputMove;
        public InputAction @InputJump => m_Wrapper.m_PlayerControls_InputJump;
        public InputAction @InputAbility => m_Wrapper.m_PlayerControls_InputAbility;
        public InputAction @InputSuicide => m_Wrapper.m_PlayerControls_InputSuicide;
        public InputAction @InputInteract => m_Wrapper.m_PlayerControls_InputInteract;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @InputMove.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputMove;
                @InputMove.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputMove;
                @InputMove.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputMove;
                @InputJump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputJump;
                @InputJump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputJump;
                @InputJump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputJump;
                @InputAbility.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputAbility;
                @InputAbility.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputAbility;
                @InputAbility.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputAbility;
                @InputSuicide.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputSuicide;
                @InputSuicide.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputSuicide;
                @InputSuicide.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputSuicide;
                @InputInteract.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputInteract;
                @InputInteract.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputInteract;
                @InputInteract.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInputInteract;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InputMove.started += instance.OnInputMove;
                @InputMove.performed += instance.OnInputMove;
                @InputMove.canceled += instance.OnInputMove;
                @InputJump.started += instance.OnInputJump;
                @InputJump.performed += instance.OnInputJump;
                @InputJump.canceled += instance.OnInputJump;
                @InputAbility.started += instance.OnInputAbility;
                @InputAbility.performed += instance.OnInputAbility;
                @InputAbility.canceled += instance.OnInputAbility;
                @InputSuicide.started += instance.OnInputSuicide;
                @InputSuicide.performed += instance.OnInputSuicide;
                @InputSuicide.canceled += instance.OnInputSuicide;
                @InputInteract.started += instance.OnInputInteract;
                @InputInteract.performed += instance.OnInputInteract;
                @InputInteract.canceled += instance.OnInputInteract;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnInputMove(InputAction.CallbackContext context);
        void OnInputJump(InputAction.CallbackContext context);
        void OnInputAbility(InputAction.CallbackContext context);
        void OnInputSuicide(InputAction.CallbackContext context);
        void OnInputInteract(InputAction.CallbackContext context);
    }
}
