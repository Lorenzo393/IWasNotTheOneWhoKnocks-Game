using System.Runtime.CompilerServices;
using UnityEngine;

public class SwitchInteraction : MonoBehaviour
{
    SimpleInteraction simpleInteraction;
    private void Awake(){
        simpleInteraction = gameObject.GetComponent<SimpleInteraction>();
    }
    private void OnEnable(){
        simpleInteraction.OnStateChange += UpdateState;
        UpdateState(simpleInteraction.IsActive);
    }
    private void OnDisable(){
        simpleInteraction.OnStateChange -= UpdateState;
    }
    private void UpdateState(bool isActive){
        Debug.Log(isActive);
    }
}
