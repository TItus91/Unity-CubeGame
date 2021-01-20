
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public Transform player;
	public Vector3 offset = new Vector3(-5f, 3, 0);

	private void Update()
	{
		transform.position = player.position + offset;
	}
}
