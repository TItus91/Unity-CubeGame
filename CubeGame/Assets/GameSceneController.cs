using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{

	public PlayerMovement playerMovement;
	public Transform playerPosition;
	public Text score;
	bool gameOver = false;
	public GameObject restartButton;
	

	public void GameOver ()
	{
		playerMovement.enabled = false;
		gameOver = true;
		restartButton.SetActive(true);
	}

	private void Update()
	{
		if (!gameOver)
		{
			score.text = playerPosition.position.x.ToString("0");
		}
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


}
