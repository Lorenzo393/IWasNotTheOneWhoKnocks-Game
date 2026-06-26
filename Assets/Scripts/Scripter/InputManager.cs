using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance {get; private set;}
    private InputSystem_Actions inputActions;
    private event EventHandler OnInteract;
    
    private void OnEnable(){
        Instance = this;
        inputActions = new InputSystem_Actions();
        inputActions.UI.Disable();
        inputActions.Movement.Enable();
        inputActions.Interactions.Enable();

        inputActions.Interactions.Interact.performed += Interact_performed;
    }
    private void OnDisable(){
        inputActions.Interactions.Interact.performed -= Interact_performed;
    }
    
    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj){
        OnInteract?.Invoke(this, EventArgs.Empty);
    }
    public Vector2 GetMovementVector2Normalized(){
        Vector2 vector = inputActions.Movement.Move.ReadValue<Vector2>();
        return vector;
    }
}