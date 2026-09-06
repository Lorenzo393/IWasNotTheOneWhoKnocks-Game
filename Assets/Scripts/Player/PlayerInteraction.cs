using System;
using UnityEngine;
public class PlayerInteraction : MonoBehaviour
{
    private Transform InteractorSource;
    [SerializeField] private float InteractRange = 3.0f;

    private void Start(){
        InputManager.Instance.OnInteract += InputManager_OnInteract;
    }
    private void InputManager_OnInteract(object sender, EventArgs e){
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit raycasthit, InteractRange)){
            if(raycasthit.collider.gameObject.TryGetComponent(out IInteractable interactable)){
                interactable.Interact();
            }
        }
    }
}
