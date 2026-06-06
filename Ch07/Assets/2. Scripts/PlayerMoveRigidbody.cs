using UnityEngine;

public class PlayerMoveRigidbody : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * rotationSpeed = Time.deltaTime;
        float zSpeed = zInput * movespeed = Time.deltaTime;

        transform.Rotate(0, xSpeed, 0);
        rb.linearVelocity = zSpeed * transform.forward;
    }
}
