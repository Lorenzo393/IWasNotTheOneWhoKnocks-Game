using UnityEngine;

public class SwitchInteraction : MonoBehaviour, IInteractable
{
    private bool isActive = true;
    public void Interact(){
        isActive = !isActive;
        Debug.Log(isActive);
    }
}
