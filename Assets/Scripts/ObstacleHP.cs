using UnityEngine;

public class ObstacleHP : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 10;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            health -= 5;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
