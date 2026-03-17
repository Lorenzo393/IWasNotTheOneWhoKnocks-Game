using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraTrasform;
    [SerializeField] private float movementSpeed = 6f;
    private CharacterController characterController;

    private void Awake(){
        characterController = GetComponent<CharacterController>();
    }
    private void Update(){
        PlayerMove();
    }

    private void PlayerMove(){
        Vector2 inputMovement = GameInput.Instance.GetPlayerInputVectorNormalized();
        Vector3 playerMove = (inputMovement.y * cameraTrasform.forward) + (inputMovement.x * cameraTrasform.right);
        playerMove.y = 0f;
        playerMove *= movementSpeed;
        
        characterController.Move(playerMove * Time.deltaTime);
    }

    
}
