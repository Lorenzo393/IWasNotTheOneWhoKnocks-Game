using UnityEngine;
public class SwitchAnimation : MonoBehaviour
{
    [SerializeField] private SimpleInteraction simpleInteraction;
    private void OnEnable(){
        simpleInteraction.OnStateChange += UpdateState;
        UpdateState(simpleInteraction.IsActive);
    }
    private void OnDisable(){
        simpleInteraction.OnStateChange -= UpdateState;
    }
    private void UpdateState(bool isActive){
        Vector3 rotation = isActive? new Vector3(15f,0f,0f) : new Vector3(0f,0f,0f);
        transform.localRotation = Quaternion.Euler(rotation);
    }
}
