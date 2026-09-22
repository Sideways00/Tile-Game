using UnityEngine;

public class ObstacleGrid : MonoBehaviour
{
    public GameObject obstaclePrefab; // The prefab for the obstacle
    public int rows = 11; // The number of rows in the grid
    public int cols = 6; // The number of columns in the grid
    public float spacing = 5f; // The size of each cell in the grid
    public float obstacleProbability = 0.5f; // The probability of an obstacle being placed in a cell
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int row = 0; row < rows; row++)
        { 
            for (int col = 0; col < cols; col++)
            {
                if(Random.value < obstacleProbability)
                {
                    float x = (col - cols / 2) * spacing; // Calculate the x position based on the column index
                    float z = (row - rows / 2) * spacing; // Calculate the z position based on the row index
                    Vector3 position = transform.position + transform.right * x + transform.forward * z;
                    Instantiate(obstaclePrefab, position, transform.rotation);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
