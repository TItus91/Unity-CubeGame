using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
	public GameSceneController gameSceneController;
	//public GameObject coin;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Obstacle")
		{
			gameSceneController.GameOver();
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Coin")
		{
			gameSceneController.score += 10;
			Destroy(other.gameObject);
		}
	}




}
