using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour { 

    public GameObject obstacle;
    public float startingDistance = 20f;
    public float constDistance = 20f;
    public float UPPERLIMIT = 7f;
    public float LOWERLIMIT = -7f;
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GenerateObstacle();
        }
    }
    public void GenerateObstacle()
    {
        Instantiate(obstacle, new Vector3(startingDistance, Random.Range(UPPERLIMIT, LOWERLIMIT), 0), Quaternion.Euler(0,0,0));
        startingDistance += constDistance;
    }
}
