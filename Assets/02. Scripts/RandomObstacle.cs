using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacle : MonoBehaviour
{
    public GameObject[] obstacles; 
    public float obstacleSpeed = 2f; 
    
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
        foreach (var obstacle in obstacles)
        {
            obstacle.SetActive(false);
        }

        int ranInt = Random.Range(0, 4);
        obstacleType = (Obstacle_TYPE)ranInt;

        
        switch (obstacleType)
        {
            case Obstacle_TYPE.LEFT:
                obstacles[0].SetActive(true); 
                break;

            case Obstacle_TYPE.RIGHT:
                obstacles[2].SetActive(true); 
                break;

            case Obstacle_TYPE.MIDDLE:
                obstacles[1].SetActive(true);
                break;

            case Obstacle_TYPE.SIDE:
                obstacles[0].SetActive(true);
                obstacles[2].SetActive(true);
                break;
        }
    }
}