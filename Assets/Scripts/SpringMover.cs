using UnityEngine;

public class SpringMover : MonoBehaviour
{
    public Rigidbody ball;
    public float maxPower = 1000f;
    public float chargeSpeed = 500f;
    private float power = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            power += chargeSpeed * Time.deltaTime;
            power = Mathf.Clamp(power, 0f, maxPower);
        }
        if(Input.GetMouseButtonUp(0))
        {
            ball.AddForce(transform.forward * power);
            power = 0f;
        }
    }
}
