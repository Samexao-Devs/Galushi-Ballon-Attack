using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	public void RestartButton()
	{
		SceneManager.LoadScene("SampleScene");
		PlayerController.vidaActual = 10;
		ScoreScript.scoreValue = 0;

	}
	public void MainButton()
	{
		SceneManager.LoadScene("New Scene");
		PlayerController.vidaActual = 10;
		ScoreScript.scoreValue = 0;
	}
}
