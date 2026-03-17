using System;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance {get; private set;}
    private InputSystem_Actions inputActions;
    public event EventHandler OnInteract;
    

    private void Awake(){
        Instance = this;
        inputActions = new InputSystem_Actions();

        PlayerEnable();
        UIDisable();

        inputActions.Player.Interact.performed += InputActions_PlayerInteract_Performed;
    }
    private void InputActions_PlayerInteract_Performed(UnityEngine.InputSystem.InputAction.CallbackContext obj){
        OnInteract?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetPlayerInputVectorNormalized(){
        return inputActions.Player.Move.ReadValue<Vector2>();
    }
    public void PlayerEnable(){
        inputActions.Player.Enable();
    }
    public void UIEnable(){
        inputActions.UI.Enable();
    }
    public void PlayerDisable(){
        inputActions.Player.Disable();
    }
    public void UIDisable(){
        inputActions.UI.Disable();
    }

}
