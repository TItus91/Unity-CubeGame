using UnityEngine;

public class LevelEnd : MonoBehaviour
{
	public GameObject levelComplete;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			levelComplete.SetActive(true);
		}
	}
}
