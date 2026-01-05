using UnityEngine;

public class SimpleCharMovementRigidbody : MonoBehaviour
{
    [SerializeField] float speed = 3;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 NewVelocity = new Vector3 (moveX*speed, 0.0f, moveY*speed);
        rb.linearVelocity = NewVelocity;
    }
}
