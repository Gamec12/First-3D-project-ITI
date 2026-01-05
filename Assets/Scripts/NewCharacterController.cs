using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class NewCharacterController : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] float mouseSensitivity;
    float xRotation = 0;
    Vector2 moveInput;
    Vector2 lookInput;
    Animator anim;
    CharacterController characterController;
    [SerializeField] GameObject firstPerson;
    [SerializeField] GameObject thirdPerson;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        thirdPerson.SetActive(true);
        firstPerson.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {

        transform.Rotate(lookInput.x * mouseSensitivity * Vector3.up);

        xRotation -= lookInput.y * mouseSensitivity;
        xRotation = Mathf.Clamp(xRotation, -90f, 60f);

        if (firstPerson.activeSelf)
            firstPerson.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        else
            thirdPerson.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        bool isMoving = moveInput.magnitude > 0;
        Debug.Log(isMoving);
        anim.SetBool("isRunning", isMoving);

        Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
        characterController.Move(move * Time.deltaTime * speed);


    }


    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    public void OnSwitchCamera(InputValue value)
    {
        firstPerson.SetActive(!firstPerson.activeSelf);
        thirdPerson.SetActive(!thirdPerson.activeSelf);
    }
    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }
}
