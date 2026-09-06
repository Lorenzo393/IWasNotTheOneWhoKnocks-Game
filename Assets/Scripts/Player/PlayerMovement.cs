using UnityEngine;
using Unity.Cinemachine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CinemachinePanTilt cameraPanTilt;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float moveSpeed = 7f;
    private CharacterController characterController;

    private Vector3 velocity;

    private void Awake(){
        characterController = GetComponent<CharacterController>();
    }
    private void Update(){
        Move();
        ApplyGravity();
    }

    private void Move(){
        Vector2 input = InputManager.Instance.GetMovementVector2Normalized();

        Vector3 forward = cameraPanTilt.transform.forward;
        Vector3 right = cameraPanTilt.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection =forward * input.y + right * input.x;
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void ApplyGravity(){
        if (characterController.isGrounded && velocity.y < 0f)
            velocity.y = -2f;
    
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
