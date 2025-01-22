using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacle : MonoBehaviour
{
    public GameObject[] obstacles; // 장애물 배열
    public float obstacleSpeed = 2f; // 장애물 이동 속도
    
    public enum Obstacle_TYPE
    {
        LEFT,
        RIGHT,
        MIDDLE,
        SIDE,
    }
    public Obstacle_TYPE obstacleType;

    void Start()
    {
        randomObstacle();
    }

    void Update()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].transform.position -= new Vector3(0f, obstacleSpeed * Time.deltaTime, 0f);
            if (obstacles[i].transform.position.y <= -6)
            {
                obstacles[i].transform.position = new Vector3(obstacles[i].transform.position.x, 6f, obstacles[i].transform.position.z );
                randomObstacle();
            }
        }
    }

    public void randomObstacle()
    {
        // 모든 장애물을 먼저 비활성화
        foreach (var obstacle in obstacles)
        {
            obstacle.SetActive(false);
        }

        int ranInt = Random.Range(0, 4);
        obstacleType = (Obstacle_TYPE)ranInt;

        // 선택된 타입에 따라 장애물 활성화
        switch (obstacleType)
        {
            case Obstacle_TYPE.LEFT:
                obstacles[0].SetActive(true); // 왼쪽 장애물 활성화
                break;

            case Obstacle_TYPE.RIGHT:
                obstacles[2].SetActive(true); // 오른쪽 장애물 활성화
                break;

            case Obstacle_TYPE.MIDDLE:
                obstacles[1].SetActive(true); // 중간 장애물 활성화
                break;

            case Obstacle_TYPE.SIDE:
                obstacles[0].SetActive(true); // 양쪽 장애물 활성화
                obstacles[2].SetActive(true);
                break;
        }
    }
}