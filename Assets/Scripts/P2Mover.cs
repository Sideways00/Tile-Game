using UnityEngine;

public class P2Mover : MonoBehaviour
{
    public float upAngle = 45f;
    public float downAngle = 0f;
    public float rotateSpeed = 500f;
    private Quaternion startingRotation;
    void Start()
    {
        startingRotation = transform.localRotation;
    }

    void Update()
    {
        float targetAngle;
        if (Input.GetKey(KeyCode.D))
        {
            targetAngle = upAngle;
        }
        else
        {
            targetAngle = downAngle;
        }
        Quaternion targetRotation = startingRotation * Quaternion.Euler(0f, -targetAngle, 0f);
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetRotation, rotateSpeed * Time.deltaTime);
    }
}
