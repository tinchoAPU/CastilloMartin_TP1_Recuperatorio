using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnRate = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, transform.rotation);
    }
}
