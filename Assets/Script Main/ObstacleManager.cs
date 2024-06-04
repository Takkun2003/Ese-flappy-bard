using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // áŠQ•¨‚ÌƒvƒŒƒnƒu
    public float spawnInterval = 120f; // áŠQ•¨‚Ì¶¬ŠÔŠu
    public float obstacleSpeed = 2f; // áŠQ•¨‚ÌƒXƒNƒ[ƒ‹‘¬“x
    public float obstacleWidth = 1f; // áŠQ•¨‚Ì•
    [SerializeField] GameObject camera;
    public Vector2 spawnRangeY = new Vector2(-2f, 2f); // áŠQ•¨‚Ì¶¬ˆÊ’u‚ÌY”ÍˆÍ

    private float timeSinceLastSpawn = 0;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObstacle()
    {
        float spawnY = Random.Range(spawnRangeY.x, spawnRangeY.y);
        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, spawnY, 0);
        GameObject newObstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
      //  newObstacle.GetComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed, 0);
    }
}
