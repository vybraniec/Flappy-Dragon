using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public GameObject gameOverPanel;
    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
        }
        gameOverPanel.SetActive(true);
    } 

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
