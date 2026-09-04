using UnityEngine;
public class DoorAnimation : MonoBehaviour
{
    private static readonly int IsOpenHash = Animator.StringToHash("isOpen");
    [SerializeField] SimpleInteraction simpleInteraction;
    Animator animator;
    private void Awake(){
        animator = GetComponent<Animator>();
    }
    private void OnEnable(){
        simpleInteraction.OnStateChange += UpdateState;
    }
    private void OnDisable(){
        simpleInteraction.OnStateChange -= UpdateState;
    }
    private void UpdateState(bool isActive){
        Debug.Log(isActive);
        animator.SetBool(IsOpenHash, isActive);
    }
}
