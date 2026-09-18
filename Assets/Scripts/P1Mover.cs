using UnityEngine;

public class P1Mover : MonoBehaviour
{
    public Transform hingePoint;
    public float rotateSpeed = 500f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(hingePoint.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

}
