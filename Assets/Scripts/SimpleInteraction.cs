using System;
using UnityEngine;

public class SimpleInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private bool isBlocked = false;
    [SerializeField] private bool isActive = false;
    public bool IsActive => isActive;
    public event Action<bool> OnStateChange;
    public void Interact(){
        if (!isBlocked){
            isActive = !isActive;
            OnStateChange?.Invoke(isActive);   
        } 
    }
    public void Block(){
        isBlocked = true;
    }
    public void Unblock(){
        isBlocked = false;
    }
}
