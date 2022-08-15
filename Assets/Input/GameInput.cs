//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/GameInput.inputactions
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

public partial class @GameInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Pitcher"",
            ""id"": ""93cad294-c3e3-47d6-afdd-0b21070c0bbe"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""2d9103b5-2b02-434a-a292-3c40e96fe511"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""7537a514-1993-43f4-beb3-ec27973fe095"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9485a550-53d1-4fa1-9207-e22e66962d02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75932768-92b3-49cd-9ab7-302627b5ed95"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4d721ab5-ed27-45ee-8810-548df31baa4c"",
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
                    ""id"": ""c76f6054-383d-4f59-a69b-a53ce9abfd84"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1637783d-af70-45ad-9c05-5655ddb653a6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dd9fe9c0-cd84-4411-a5cb-3a9176b78f01"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""deccddc7-1a78-4742-88bb-9f4ee65b29a6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""936ba871-6900-4096-9585-927f163a25d5"",
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
                    ""id"": ""c76905e7-758d-4048-bd69-46cd7bdf6c81"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6d1c25b-915a-41ce-8457-1102989ff0d6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3895873a-e2f9-4eec-87db-44b2d693e331"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a854a069-3f04-4792-82e7-74282fb4df85"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5bf1a0a3-9004-4aa3-8a7d-003d79b6932f"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold(duration=0.05,pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d45481df-050a-4b1b-bcef-ccdd03723a06"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""22a7e9b8-3b08-4221-ad4f-bb155c1d4dc3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7165e398-9be2-475e-b52f-99c2595af8e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""67fc3f3d-a043-4d24-af5f-86a437f99855"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BatterNRunner"",
            ""id"": ""dcd4be4a-900d-4717-b2ab-f457d9cadf53"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c6f31637-6153-4977-bffd-1d27695b2763"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Swing"",
                    ""type"": ""Button"",
                    ""id"": ""2756860e-e38c-4759-bf8d-5586b2ac7689"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bunt"",
                    ""type"": ""Button"",
                    ""id"": ""ce74cadf-7395-41f5-bb13-a230a20e42ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c8d896c3-4a39-4d35-b713-2331cbff82c5"",
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
                    ""id"": ""c652f3ba-2318-4801-b735-f7952ed5ae58"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9c1bf03-3ad0-4421-b8fa-985e5dd569aa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""00a96f84-83ea-42ad-802a-1f868e8c74aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8e5e5ad9-d022-49ea-b2cc-1f9cb7133f1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""634fd400-e33c-4f7b-87c6-c7b7d77355cd"",
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
                    ""id"": ""918919f0-8400-425a-8f61-b8b4ecc3957f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53ae3480-b919-43f1-ac4b-a6a1b848c4ed"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a62431a2-d89f-4f91-9358-a006f102835a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d101982-ee96-41eb-9146-e323e719f0a1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a85beb2-6092-4b23-8ec6-ccf4cd8d2a2e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d2319e9-5ce5-4a6c-ab9b-ac3a61c11feb"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Defense"",
            ""id"": ""eb557f08-ce1c-4ede-8f5c-d5206d2edba3"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""db3ee444-ee52-4819-a279-87e30cbe8eef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a29acc3b-b8cd-45ed-848b-3b54dfd4e2cd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pitcher
        m_Pitcher = asset.FindActionMap("Pitcher", throwIfNotFound: true);
        m_Pitcher_Select = m_Pitcher.FindAction("Select", throwIfNotFound: true);
        m_Pitcher_Confirm = m_Pitcher.FindAction("Confirm", throwIfNotFound: true);
        m_Pitcher_Move = m_Pitcher.FindAction("Move", throwIfNotFound: true);
        // BatterNRunner
        m_BatterNRunner = asset.FindActionMap("BatterNRunner", throwIfNotFound: true);
        m_BatterNRunner_Move = m_BatterNRunner.FindAction("Move", throwIfNotFound: true);
        m_BatterNRunner_Swing = m_BatterNRunner.FindAction("Swing", throwIfNotFound: true);
        m_BatterNRunner_Bunt = m_BatterNRunner.FindAction("Bunt", throwIfNotFound: true);
        // Defense
        m_Defense = asset.FindActionMap("Defense", throwIfNotFound: true);
        m_Defense_Newaction = m_Defense.FindAction("New action", throwIfNotFound: true);
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

    // Pitcher
    private readonly InputActionMap m_Pitcher;
    private IPitcherActions m_PitcherActionsCallbackInterface;
    private readonly InputAction m_Pitcher_Select;
    private readonly InputAction m_Pitcher_Confirm;
    private readonly InputAction m_Pitcher_Move;
    public struct PitcherActions
    {
        private @GameInput m_Wrapper;
        public PitcherActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Pitcher_Select;
        public InputAction @Confirm => m_Wrapper.m_Pitcher_Confirm;
        public InputAction @Move => m_Wrapper.m_Pitcher_Move;
        public InputActionMap Get() { return m_Wrapper.m_Pitcher; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PitcherActions set) { return set.Get(); }
        public void SetCallbacks(IPitcherActions instance)
        {
            if (m_Wrapper.m_PitcherActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_PitcherActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PitcherActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PitcherActionsCallbackInterface.OnSelect;
                @Confirm.started -= m_Wrapper.m_PitcherActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PitcherActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PitcherActionsCallbackInterface.OnConfirm;
                @Move.started -= m_Wrapper.m_PitcherActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PitcherActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PitcherActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PitcherActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PitcherActions @Pitcher => new PitcherActions(this);

    // BatterNRunner
    private readonly InputActionMap m_BatterNRunner;
    private IBatterNRunnerActions m_BatterNRunnerActionsCallbackInterface;
    private readonly InputAction m_BatterNRunner_Move;
    private readonly InputAction m_BatterNRunner_Swing;
    private readonly InputAction m_BatterNRunner_Bunt;
    public struct BatterNRunnerActions
    {
        private @GameInput m_Wrapper;
        public BatterNRunnerActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BatterNRunner_Move;
        public InputAction @Swing => m_Wrapper.m_BatterNRunner_Swing;
        public InputAction @Bunt => m_Wrapper.m_BatterNRunner_Bunt;
        public InputActionMap Get() { return m_Wrapper.m_BatterNRunner; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BatterNRunnerActions set) { return set.Get(); }
        public void SetCallbacks(IBatterNRunnerActions instance)
        {
            if (m_Wrapper.m_BatterNRunnerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnMove;
                @Swing.started -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnSwing;
                @Swing.performed -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnSwing;
                @Swing.canceled -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnSwing;
                @Bunt.started -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnBunt;
                @Bunt.performed -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnBunt;
                @Bunt.canceled -= m_Wrapper.m_BatterNRunnerActionsCallbackInterface.OnBunt;
            }
            m_Wrapper.m_BatterNRunnerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Swing.started += instance.OnSwing;
                @Swing.performed += instance.OnSwing;
                @Swing.canceled += instance.OnSwing;
                @Bunt.started += instance.OnBunt;
                @Bunt.performed += instance.OnBunt;
                @Bunt.canceled += instance.OnBunt;
            }
        }
    }
    public BatterNRunnerActions @BatterNRunner => new BatterNRunnerActions(this);

    // Defense
    private readonly InputActionMap m_Defense;
    private IDefenseActions m_DefenseActionsCallbackInterface;
    private readonly InputAction m_Defense_Newaction;
    public struct DefenseActions
    {
        private @GameInput m_Wrapper;
        public DefenseActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Defense_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Defense; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefenseActions set) { return set.Get(); }
        public void SetCallbacks(IDefenseActions instance)
        {
            if (m_Wrapper.m_DefenseActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_DefenseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public DefenseActions @Defense => new DefenseActions(this);
    public interface IPitcherActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IBatterNRunnerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSwing(InputAction.CallbackContext context);
        void OnBunt(InputAction.CallbackContext context);
    }
    public interface IDefenseActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}