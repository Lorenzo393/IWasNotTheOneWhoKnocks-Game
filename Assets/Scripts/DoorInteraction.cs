using UnityEngine;

public class DoorInteraction : MonoBehaviour, IInteractable
{
    private bool isOpen = false;
    public void Interact(){
        isOpen = !isOpen;
        Debug.Log(isOpen);
    }
}
