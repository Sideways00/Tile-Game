using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float minimumSpeed = 8f; // Minimum speed of the ball
    public float maximumSpeed = 20f; // Maximum speed of the ball
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.linearVelocity.magnitude < minimumSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * minimumSpeed;
        }
        else if (rb.linearVelocity.magnitude > maximumSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maximumSpeed;
        }
    }
}
