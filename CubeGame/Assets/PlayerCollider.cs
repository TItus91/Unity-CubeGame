using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
	public GameSceneController gameSceneController;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Obstacle")
		{
			Debug.Log("Obstacle hit");
			gameSceneController.GameOver();
			//Invoke("Restart", 2f);   // Invoke powoduje uzycie metody po czasie okreslonym w drugim argumencie
			
		}
	}

	

	
}
