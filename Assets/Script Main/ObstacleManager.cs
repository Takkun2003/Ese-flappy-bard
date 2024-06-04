using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // ��Q���̃v���n�u
    public float spawnInterval = 120f; // ��Q���̐����Ԋu
    public float obstacleSpeed = 2f; // ��Q���̃X�N���[�����x
    public float obstacleWidth = 1f; // ��Q���̕�
    [SerializeField] GameObject camera;
    public Vector2 spawnRangeY = new Vector2(-2f, 2f); // ��Q���̐����ʒu��Y�͈�

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
