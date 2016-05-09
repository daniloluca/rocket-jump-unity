using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	
	[Range(0.0f, 1.0f)]
	public float smooth = 0.5f;
	[Range(-10.0f, 10.0f)]
	public float cameraPosX = 0f;
	[Range(-10.0f, 10.0f)]
	public float cameraPosY = 0f;

	private Vector2 speed;

	// Use this for initialization
	void Start () {

		speed = new Vector2 (0.5f, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 newPosition2D = Vector2.zero;

		newPosition2D.x = Mathf.SmoothDamp(transform.position.x, player.position.x + cameraPosX, ref speed.x, smooth);
		newPosition2D.y = Mathf.SmoothDamp(transform.position.y, player.position.y + cameraPosY, ref speed.y, smooth);

		Vector3 newCameraPosition = new Vector3(newPosition2D.x, newPosition2D.y, transform.position.z);

		transform.position = Vector3.Slerp(transform.position, newCameraPosition, Time.time);
	}
}