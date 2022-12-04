using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    ObstacleGenerator obstacleGenerator;
    public Score score;
    void Start()
    {
        score = FindObjectOfType<TextMeshProUGUI>().GetComponent<Score>();
        obstacleGenerator = FindObjectOfType<ObstacleGenerator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        score.points++;
        obstacleGenerator.GenerateObstacle();
    }
}
