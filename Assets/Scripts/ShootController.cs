using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour {

	public GameObject bulletPrefab;
	public GameObject gunTag;
	public float force = 100f;

	void Start () {
	
	}
	
	void Update () {		
		if (Input.GetMouseButtonDown(0)){
			GameObject projectile = (GameObject) Instantiate(bulletPrefab, gunTag.transform.position, Quaternion.identity);
			Vector3 screenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			Vector3 direc = new Vector3(screenPos.x, screenPos.y, gunTag.transform.position.z) - gunTag.transform.position;
			direc.Normalize();

         	projectile.GetComponent<Rigidbody>().AddForce(direc*force);
		}
	}
}
