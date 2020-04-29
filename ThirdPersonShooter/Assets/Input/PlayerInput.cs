// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

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
            ""name"": ""PlayerInputMap"",
            ""id"": ""41278dae-e39d-426d-be94-f998f4902a1e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ef0e4bce-d5e4-4541-9ce9-e2277aa2cba1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8f8b64dd-c852-4b03-8a1d-0e54c9db5fca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""0a7f7a0f-1d77-4585-92c8-5170a5955013"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""cda1e96d-5dad-4a1d-ad0c-68e9bbc9f56f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""af70e289-ceca-4a6a-af4c-1b4625632c08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5d8c49ee-e289-4ccb-8556-0ba352407e48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""dce6ea07-2d3e-48e1-8889-ac9314e36124"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""6ce2df32-030d-49a2-8aaf-8ed0d3a8de9f"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetCamera"",
                    ""type"": ""Button"",
                    ""id"": ""1b78d7d2-6bdd-4f56-a299-42ef7191a8c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e992a21-51bf-4ffc-a625-abf2720e1bf3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b7ef8371-5791-48bc-bf1e-b32679b7d54d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f803bbd0-3063-4e30-b825-fed1a298a671"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4717b4af-47fe-48bc-9dac-40d3a810550b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e869350-8db6-47de-a91b-0d10482253b0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ff3077c4-cf31-4760-b1f8-ceabeffe9b8d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e0df951-085e-4f95-acd3-a0ab2f687879"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2,StickDeadzone,ScaleVector2(x=2,y=5)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a7d9e37-747f-46cd-aeaf-87f7def126a7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2,ScaleVector2(x=0.5,y=2)"",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59f32740-7e9e-4250-8023-a4ebfc37b5d9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7afea57-9cda-463f-a96c-e43d4c51d029"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d86c282d-d5b5-4a6c-9019-98d76816ea38"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0fd02a2-950f-4166-a0da-a63c2f78a626"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5aba9632-5b9d-4632-a33b-f5d2b0367886"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""173af0a0-fdbc-4835-a762-ed9947b219a7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""577d7a86-44cc-41c8-95f3-48fb738cdaa6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""268c8ec6-2b12-4a56-befe-22da7ba0f2b0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4edbe952-990a-48ed-8b37-c94d0d492e0f"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d0c9c24d-0450-4607-9547-55f6570ce1ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""67eaf492-af09-419c-9d6c-fcdaf7cc4650"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5c40892c-a76c-4a6e-b8bd-99c6491c99b5"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7c31a77d-bb99-45d7-9113-56d6e8413344"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3472b288-3b9d-4caf-80f2-fd0ef361b242"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a5491171-af76-45e6-8006-49064d62a029"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bf461e3-8480-4150-9967-5b8c4d8881d2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71c34158-3b82-42ad-bf76-9e3fee17d703"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ResetCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e3e1c61-0363-4fa6-982a-e3cb47f72f5a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""ResetCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
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
        // PlayerInputMap
        m_PlayerInputMap = asset.FindActionMap("PlayerInputMap", throwIfNotFound: true);
        m_PlayerInputMap_Move = m_PlayerInputMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerInputMap_Look = m_PlayerInputMap.FindAction("Look", throwIfNotFound: true);
        m_PlayerInputMap_Aim = m_PlayerInputMap.FindAction("Aim", throwIfNotFound: true);
        m_PlayerInputMap_Shoot = m_PlayerInputMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerInputMap_Crouch = m_PlayerInputMap.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerInputMap_Jump = m_PlayerInputMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInputMap_Pickup = m_PlayerInputMap.FindAction("Pickup", throwIfNotFound: true);
        m_PlayerInputMap_ScrollWeapon = m_PlayerInputMap.FindAction("ScrollWeapon", throwIfNotFound: true);
        m_PlayerInputMap_ResetCamera = m_PlayerInputMap.FindAction("ResetCamera", throwIfNotFound: true);
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

    // PlayerInputMap
    private readonly InputActionMap m_PlayerInputMap;
    private IPlayerInputMapActions m_PlayerInputMapActionsCallbackInterface;
    private readonly InputAction m_PlayerInputMap_Move;
    private readonly InputAction m_PlayerInputMap_Look;
    private readonly InputAction m_PlayerInputMap_Aim;
    private readonly InputAction m_PlayerInputMap_Shoot;
    private readonly InputAction m_PlayerInputMap_Crouch;
    private readonly InputAction m_PlayerInputMap_Jump;
    private readonly InputAction m_PlayerInputMap_Pickup;
    private readonly InputAction m_PlayerInputMap_ScrollWeapon;
    private readonly InputAction m_PlayerInputMap_ResetCamera;
    public struct PlayerInputMapActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerInputMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerInputMap_Move;
        public InputAction @Look => m_Wrapper.m_PlayerInputMap_Look;
        public InputAction @Aim => m_Wrapper.m_PlayerInputMap_Aim;
        public InputAction @Shoot => m_Wrapper.m_PlayerInputMap_Shoot;
        public InputAction @Crouch => m_Wrapper.m_PlayerInputMap_Crouch;
        public InputAction @Jump => m_Wrapper.m_PlayerInputMap_Jump;
        public InputAction @Pickup => m_Wrapper.m_PlayerInputMap_Pickup;
        public InputAction @ScrollWeapon => m_Wrapper.m_PlayerInputMap_ScrollWeapon;
        public InputAction @ResetCamera => m_Wrapper.m_PlayerInputMap_ResetCamera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInputMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputMapActions instance)
        {
            if (m_Wrapper.m_PlayerInputMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnLook;
                @Aim.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnAim;
                @Shoot.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnShoot;
                @Crouch.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnJump;
                @Pickup.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnPickup;
                @ScrollWeapon.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnScrollWeapon;
                @ScrollWeapon.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnScrollWeapon;
                @ScrollWeapon.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnScrollWeapon;
                @ResetCamera.started -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_PlayerInputMapActionsCallbackInterface.OnResetCamera;
            }
            m_Wrapper.m_PlayerInputMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @ScrollWeapon.started += instance.OnScrollWeapon;
                @ScrollWeapon.performed += instance.OnScrollWeapon;
                @ScrollWeapon.canceled += instance.OnScrollWeapon;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
            }
        }
    }
    public PlayerInputMapActions @PlayerInputMap => new PlayerInputMapActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface IPlayerInputMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnScrollWeapon(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
    }
}
