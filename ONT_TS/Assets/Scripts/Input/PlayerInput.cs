// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/PlayerInput.inputactions'

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
            ""name"": ""GamePlay"",
            ""id"": ""923b130b-9aaa-4bd2-a67c-a23eb698c0aa"",
            ""actions"": [
                {
                    ""name"": ""CamInput"",
                    ""type"": ""Value"",
                    ""id"": ""6143ebc9-58e9-4c63-a850-893d6def6366"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movements"",
                    ""type"": ""Value"",
                    ""id"": ""6d6acc04-9048-4427-8a35-1f5dc98862f6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""1e465c71-1ae5-4749-a010-5b9c8395a8ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""d93834e4-0c19-46f6-b41a-4c6b013270f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1658b034-bb3b-43af-afa9-a4e99a1cc360"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""0f28af36-7643-4650-9e19-26e94f19bc56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8ef491fc-db09-48b4-a54d-1d0fbeaf8ee9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""fa895f92-9748-4450-9ecc-3fe972a79400"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.7),Tap(duration=0.5,pressPoint=0.5)""
                },
                {
                    ""name"": ""EarthAbility"",
                    ""type"": ""Button"",
                    ""id"": ""6c68c841-dead-4d4b-a016-43216de0ab24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LifeAbility"",
                    ""type"": ""Button"",
                    ""id"": ""a11b6c83-23de-455e-b565-d1187fac4f4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6281104-c42f-4089-9d22-6576f91a4877"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af4d4996-b28a-4770-8ce1-d5e70e2a00ac"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=2,y=2)"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""CamInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13a2a025-aa25-42f4-aaec-5d86a1c80474"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38aa656c-b311-44f0-8978-ce64beb65026"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""EarthAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc85b466-1f1d-412f-a32f-95fb157b2295"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""LifeAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f1e62860-c449-4634-aa61-d3b3396cab72"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""afe75d01-2a28-464f-bb57-28a2c18c2662"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e03a06c-ebb4-42bc-9d9a-42c1973927d5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9a62113a-2866-43fb-a824-069c70959193"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c90902f8-2b75-4d06-8120-28d8d4ce20c6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fead9217-586b-4221-a88b-f1ef67382ba1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcf2add9-cd50-4dc3-a2d9-4bc25d12aa6d"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51009797-c527-4e8f-bcaf-e0979eaeba3d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b15980-12b9-4239-9ca4-e4a5e9bdcaeb"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""9853d5c3-3574-407f-a1cc-01323d714d09"",
            ""actions"": [
                {
                    ""name"": ""Choose"",
                    ""type"": ""Button"",
                    ""id"": ""ad38b0bf-a84b-4865-b8c2-7ee419880bae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d21e5f30-79be-4c1a-8a75-944662ac7ed2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""49af096d-87d3-4381-860f-62b20fb466b1"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9906a98e-bae2-43f9-9bf3-24d476d6b304"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06dd32e9-6b49-4355-977e-3a2bb13be546"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_CamInput = m_GamePlay.FindAction("CamInput", throwIfNotFound: true);
        m_GamePlay_Movements = m_GamePlay.FindAction("Movements", throwIfNotFound: true);
        m_GamePlay_Run = m_GamePlay.FindAction("Run", throwIfNotFound: true);
        m_GamePlay_Dodge = m_GamePlay.FindAction("Dodge", throwIfNotFound: true);
        m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
        m_GamePlay_Aim = m_GamePlay.FindAction("Aim", throwIfNotFound: true);
        m_GamePlay_Attack = m_GamePlay.FindAction("Attack", throwIfNotFound: true);
        m_GamePlay_HeavyAttack = m_GamePlay.FindAction("HeavyAttack", throwIfNotFound: true);
        m_GamePlay_EarthAbility = m_GamePlay.FindAction("EarthAbility", throwIfNotFound: true);
        m_GamePlay_LifeAbility = m_GamePlay.FindAction("LifeAbility", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Choose = m_Menu.FindAction("Choose", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Interact = m_Dialogue.FindAction("Interact", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_CamInput;
    private readonly InputAction m_GamePlay_Movements;
    private readonly InputAction m_GamePlay_Run;
    private readonly InputAction m_GamePlay_Dodge;
    private readonly InputAction m_GamePlay_Jump;
    private readonly InputAction m_GamePlay_Aim;
    private readonly InputAction m_GamePlay_Attack;
    private readonly InputAction m_GamePlay_HeavyAttack;
    private readonly InputAction m_GamePlay_EarthAbility;
    private readonly InputAction m_GamePlay_LifeAbility;
    public struct GamePlayActions
    {
        private @PlayerInput m_Wrapper;
        public GamePlayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CamInput => m_Wrapper.m_GamePlay_CamInput;
        public InputAction @Movements => m_Wrapper.m_GamePlay_Movements;
        public InputAction @Run => m_Wrapper.m_GamePlay_Run;
        public InputAction @Dodge => m_Wrapper.m_GamePlay_Dodge;
        public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
        public InputAction @Aim => m_Wrapper.m_GamePlay_Aim;
        public InputAction @Attack => m_Wrapper.m_GamePlay_Attack;
        public InputAction @HeavyAttack => m_Wrapper.m_GamePlay_HeavyAttack;
        public InputAction @EarthAbility => m_Wrapper.m_GamePlay_EarthAbility;
        public InputAction @LifeAbility => m_Wrapper.m_GamePlay_LifeAbility;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @CamInput.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamInput;
                @CamInput.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamInput;
                @CamInput.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamInput;
                @Movements.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovements;
                @Run.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Dodge.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDodge;
                @Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Aim.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAim;
                @Attack.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @HeavyAttack.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnHeavyAttack;
                @EarthAbility.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEarthAbility;
                @EarthAbility.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEarthAbility;
                @EarthAbility.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEarthAbility;
                @LifeAbility.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLifeAbility;
                @LifeAbility.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLifeAbility;
                @LifeAbility.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLifeAbility;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CamInput.started += instance.OnCamInput;
                @CamInput.performed += instance.OnCamInput;
                @CamInput.canceled += instance.OnCamInput;
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
                @EarthAbility.started += instance.OnEarthAbility;
                @EarthAbility.performed += instance.OnEarthAbility;
                @EarthAbility.canceled += instance.OnEarthAbility;
                @LifeAbility.started += instance.OnLifeAbility;
                @LifeAbility.performed += instance.OnLifeAbility;
                @LifeAbility.canceled += instance.OnLifeAbility;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Choose;
    public struct MenuActions
    {
        private @PlayerInput m_Wrapper;
        public MenuActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Choose => m_Wrapper.m_Menu_Choose;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Choose.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChoose;
                @Choose.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChoose;
                @Choose.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChoose;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Choose.started += instance.OnChoose;
                @Choose.performed += instance.OnChoose;
                @Choose.canceled += instance.OnChoose;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_Interact;
    public struct DialogueActions
    {
        private @PlayerInput m_Wrapper;
        public DialogueActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Dialogue_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnCamInput(InputAction.CallbackContext context);
        void OnMovements(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnEarthAbility(InputAction.CallbackContext context);
        void OnLifeAbility(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnChoose(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
}
