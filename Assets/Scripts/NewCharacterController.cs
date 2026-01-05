using UnityEngine;
using UnityEngine.InputSystem;

public class NewCharacterController : MonoBehaviour
{
    [SerializeField] float speed = 3;
    Rigidbody rb;
    Vector2 moveInput;
    Animator anim;
    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        bool isMoving = moveInput.magnitude > 0;
        Debug.Log(isMoving);
        anim.SetBool("isRunning", isMoving);
    }


    void FixedUpdate()
    {


        Vector3 NewVelocity = new Vector3(moveInput.x, 0.0f, moveInput.y);
        characterController.Move(NewVelocity * speed * Time.deltaTime);

    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
