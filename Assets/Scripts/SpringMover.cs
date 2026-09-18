using UnityEngine;

public class SpringMover : MonoBehaviour
{
    public float speed = 25f; // Speed of the movement
    public float maxDistance = 10f; // Maximum distance to move
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
