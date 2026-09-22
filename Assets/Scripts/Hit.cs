using UnityEngine;

public class Hit : MonoBehaviour
{
    public float hitForce = 100f; // The force applied to the object when hit
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ball = collision.gameObject.GetComponent<Rigidbody>();
            if (ball != null)
            {
                ball.AddForce(Vector3.up * hitForce, ForceMode.Impulse);

            }
        }

    }

}
