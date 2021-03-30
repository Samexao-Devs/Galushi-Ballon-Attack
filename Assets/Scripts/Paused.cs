using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Paused : MonoBehaviour
{
    bool isPaused=false;
    public Image PausedGame;
    public Button PauseButton;
    public void pauseGame()
    {
        if (isPaused)
        {
            PausedGame.gameObject.SetActive(false);
            PauseButton.gameObject.SetActive(true);
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            PauseButton.gameObject.SetActive(false);
            PausedGame.gameObject.SetActive(true);
            Time.timeScale = 0;
            isPaused=true;
        }
    }
    public void MainButton()
    {
        SceneManager.LoadScene("New Scene");
        PlayerController.vidaActual = 10;
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1;
        isPaused = false;
    }
}
