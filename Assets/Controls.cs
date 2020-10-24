// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""57529560-443f-43c6-b179-358f1a3c7cbc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""845ac210-d310-484f-94e3-554f54b62a35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e6902f3b-c17f-46ab-9f96-cd63c672d22c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9337249f-4c02-4e83-b389-85b55ee7f0fe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5070fbe4-b0c6-4cbf-b191-c8c665a5781d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e91dddb7-e9ca-488f-baba-ee2be1a2b626"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02fad4fc-96ee-47df-b5ad-f02fcb8c4914"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""ee8757d2-11d8-450f-954e-25a32274f733"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1ba87165-19b0-433d-9335-3d8e39631d6e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""31afc4a0-f410-4e5b-9579-b1415724eddb"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ef3591c8-bf33-4eae-b581-6a8d0592ab99"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8770ce14-7390-49dc-86f7-9f47c1b41e3a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""14276637-5fb2-4ddc-80e2-34f32d0981ac"",
            ""actions"": [
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""99dfaa68-d3f7-472f-8186-063d79900fc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""2b7af359-a258-4a11-a5c2-632e7f3bf10b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5761ad3-1b93-49fe-a84f-2366120d8238"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4171fb86-940b-4d19-95ec-f6d167058ba8"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58048f42-e170-4376-b900-5c7bc0d404e5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a15db2f-c6da-41c7-b100-886b6c4bfc72"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""2f49e345-a03f-4106-bf20-f16b8fbd1c4e"",
            ""actions"": [
                {
                    ""name"": ""Noclip"",
                    ""type"": ""Button"",
                    ""id"": ""3f0d150f-26a9-4a8f-9165-d91c3907ca63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugView"",
                    ""type"": ""Button"",
                    ""id"": ""51cb64e1-07c6-4dd2-9570-4a19bbb3420a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NoclipMovement"",
                    ""type"": ""Button"",
                    ""id"": ""a20691a7-b03b-40cc-bb8e-7988af03edfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NoclipFly"",
                    ""type"": ""Button"",
                    ""id"": ""b15ab617-99a2-4a07-9286-cb5270da533c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19051203-d0f4-4cf6-a370-71f21beb856e"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Noclip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23da367d-1999-45b5-b4df-bf9af405a6a7"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""66da0e9a-3eb8-4e1f-bfca-4672981dae6e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6a65aadd-7d7e-43eb-969e-bced37e942da"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af4b630f-263c-4e4a-8b24-f13a4f3c1bd1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f6593b5a-7093-4536-9a80-95d2a7e2ed3a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6cbf33e7-9017-4f6c-a0d7-02052d54b73f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UpDown"",
                    ""id"": ""eb9c8c59-4af8-4856-9a34-62445c84c9b9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipFly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""89f90b43-dd0b-44b7-8530-35210dd850bf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipFly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e882d7b-960b-46db-a897-00f3317ecb98"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipFly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""840fca6b-f40d-434e-a01f-2fb6062366a0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipFly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2fdbacb1-14b2-407f-9810-495f9ed28a49"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoclipFly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Next = m_Camera.FindAction("Next", throwIfNotFound: true);
        m_Camera_Previous = m_Camera.FindAction("Previous", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_Noclip = m_Debug.FindAction("Noclip", throwIfNotFound: true);
        m_Debug_DebugView = m_Debug.FindAction("DebugView", throwIfNotFound: true);
        m_Debug_NoclipMovement = m_Debug.FindAction("NoclipMovement", throwIfNotFound: true);
        m_Debug_NoclipFly = m_Debug.FindAction("NoclipFly", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Next;
    private readonly InputAction m_Camera_Previous;
    public struct CameraActions
    {
        private @Controls m_Wrapper;
        public CameraActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Next => m_Wrapper.m_Camera_Next;
        public InputAction @Previous => m_Wrapper.m_Camera_Previous;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Next.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnNext;
                @Previous.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnPrevious;
                @Previous.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnPrevious;
                @Previous.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnPrevious;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Previous.started += instance.OnPrevious;
                @Previous.performed += instance.OnPrevious;
                @Previous.canceled += instance.OnPrevious;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_Noclip;
    private readonly InputAction m_Debug_DebugView;
    private readonly InputAction m_Debug_NoclipMovement;
    private readonly InputAction m_Debug_NoclipFly;
    public struct DebugActions
    {
        private @Controls m_Wrapper;
        public DebugActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Noclip => m_Wrapper.m_Debug_Noclip;
        public InputAction @DebugView => m_Wrapper.m_Debug_DebugView;
        public InputAction @NoclipMovement => m_Wrapper.m_Debug_NoclipMovement;
        public InputAction @NoclipFly => m_Wrapper.m_Debug_NoclipFly;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @Noclip.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclip;
                @Noclip.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclip;
                @Noclip.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclip;
                @DebugView.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugView;
                @DebugView.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugView;
                @DebugView.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnDebugView;
                @NoclipMovement.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipMovement;
                @NoclipMovement.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipMovement;
                @NoclipMovement.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipMovement;
                @NoclipFly.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipFly;
                @NoclipFly.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipFly;
                @NoclipFly.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnNoclipFly;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Noclip.started += instance.OnNoclip;
                @Noclip.performed += instance.OnNoclip;
                @Noclip.canceled += instance.OnNoclip;
                @DebugView.started += instance.OnDebugView;
                @DebugView.performed += instance.OnDebugView;
                @DebugView.canceled += instance.OnDebugView;
                @NoclipMovement.started += instance.OnNoclipMovement;
                @NoclipMovement.performed += instance.OnNoclipMovement;
                @NoclipMovement.canceled += instance.OnNoclipMovement;
                @NoclipFly.started += instance.OnNoclipFly;
                @NoclipFly.performed += instance.OnNoclipFly;
                @NoclipFly.canceled += instance.OnNoclipFly;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnNext(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnNoclip(InputAction.CallbackContext context);
        void OnDebugView(InputAction.CallbackContext context);
        void OnNoclipMovement(InputAction.CallbackContext context);
        void OnNoclipFly(InputAction.CallbackContext context);
    }
}
