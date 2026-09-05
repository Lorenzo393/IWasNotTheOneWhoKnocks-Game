using UnityEngine;

public class ClosetDoorAnimation : MonoBehaviour
{
    private static readonly int IsActiveHash = Animator.StringToHash("isActive");
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
        animator.SetBool(IsActiveHash, isActive);
    }
}
