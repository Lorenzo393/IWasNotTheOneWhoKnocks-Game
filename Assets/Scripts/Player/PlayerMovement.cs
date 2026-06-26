using UnityEngine;
using Unity.Cinemachine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private CinemachinePanTilt cameraPanTilt;

    private Rigidbody rb;
    private Vector2 moveInput;

    private void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        moveInput = InputManager.Instance.GetMovementVector2Normalized();

        float panAngle = cameraPanTilt.PanAxis.Value;
        Quaternion yawRotation = Quaternion.Euler(0f, panAngle, 0f);

        rb.MoveRotation(yawRotation);

        Vector3 direction = yawRotation * new Vector3(moveInput.x, 0f, moveInput.y);
        Vector3 targetVelocity = direction.normalized * moveSpeed;
        targetVelocity.y = rb.linearVelocity.y;

        rb.linearVelocity = targetVelocity;
    }
}