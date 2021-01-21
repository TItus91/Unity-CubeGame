using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{

	public PlayerMovementForce playerMovement;
	public Transform playerPosition;
	public Text scoreText;
	public int score = 0;
	bool gameOver = false;
	public GameObject restartButton;

	private void Start()
	{
		Time.timeScale = 1f;
		Time.fixedDeltaTime = 0.02f;
	}

	public void GameOver ()
	{
		playerMovement.enabled = false;
		Time.timeScale = 0.2f;
		Time.fixedDeltaTime = Time.timeScale * 0.01f;
		gameOver = true;
		restartButton.SetActive(true);
	}

	private void Update()
	{
		if (!gameOver)
		{
			scoreText.text = score.ToString();
		}
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


}
