using UnityEngine;
using UnityEngine.InputSystem;

public class NewCharacterMovement : MonoBehaviour
{
    [SerializeField] float speed = 3;
    Rigidbody rb;
    Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

    }


    void FixedUpdate()
    {
        

        Vector3 NewVelocity = new Vector3(moveInput.x * speed, 0.0f, moveInput.y * speed);
        rb.linearVelocity = new Vector3 (NewVelocity.x, rb.linearVelocity.y, NewVelocity.z);

    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
