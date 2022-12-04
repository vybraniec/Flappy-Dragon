using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public float points = 0;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + points.ToString();
    }
}
