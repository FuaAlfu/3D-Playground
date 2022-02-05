//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/ZombieRunnerFPS/InputS/WeaponsControls.inputactions
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

public partial class @WeaponsControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @WeaponsControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""WeaponsControls"",
    ""maps"": [
        {
            ""name"": ""WeaponFiring"",
            ""id"": ""023f1bdd-5348-45aa-bfa9-64389830b5e7"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a69e6299-b0f3-4066-b1d1-ff22b87948da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""e54d6de1-18eb-458d-b952-6c019eefcd92"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""baaa9ebf-3554-4979-b335-1b6fd32e6bde"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ada80abd-57cc-4fc7-8b17-ce33ca890e53"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WeaponFiring
        m_WeaponFiring = asset.FindActionMap("WeaponFiring", throwIfNotFound: true);
        m_WeaponFiring_Shoot = m_WeaponFiring.FindAction("Shoot", throwIfNotFound: true);
        m_WeaponFiring_Zoom = m_WeaponFiring.FindAction("Zoom", throwIfNotFound: true);
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

    // WeaponFiring
    private readonly InputActionMap m_WeaponFiring;
    private IWeaponFiringActions m_WeaponFiringActionsCallbackInterface;
    private readonly InputAction m_WeaponFiring_Shoot;
    private readonly InputAction m_WeaponFiring_Zoom;
    public struct WeaponFiringActions
    {
        private @WeaponsControls m_Wrapper;
        public WeaponFiringActions(@WeaponsControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_WeaponFiring_Shoot;
        public InputAction @Zoom => m_Wrapper.m_WeaponFiring_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_WeaponFiring; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponFiringActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponFiringActions instance)
        {
            if (m_Wrapper.m_WeaponFiringActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnShoot;
                @Zoom.started -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_WeaponFiringActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_WeaponFiringActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public WeaponFiringActions @WeaponFiring => new WeaponFiringActions(this);
    public interface IWeaponFiringActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}