using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        
        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
        float horizontal = Input.GetAxis("Horizontal");
        float curSpeed = speed * horizontal;
        
        controller.SimpleMove(forward * curSpeed);

        transform.Find("Model").GetComponent<Animator>().SetFloat("Run", horizontal);
    }
}
