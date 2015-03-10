using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 5f;
	public float turnSpeed = 5f;
	public float upForce = 5f;
	private bool fall = false;
	Rigidbody rbody;
	// Use this for initialization
	void Start () {
		// "caching" a reference to the rigidbody
		rbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(GameObject.Find("TextThree").GetComponent<Dead>().done == false && GameObject.Find("TextTwo").GetComponent<Objective>().start == true){
		// INPUT AXES: a cirtual joystick that returns a float from -1 to 1
		if (fall == false){
		
		rbody.AddForce (transform.forward * speed * Input.GetAxis("Vertical"));

		}
		else{
		rbody.AddForce (transform.forward * speed *0.15f* Input.GetAxis("Vertical"));
		}

		//if (Input.GetKey("space") && fall == false){
		//	rbody.AddForce(transform.up * 200 * upForce);
		//	rbody.GetComponent<Hurtable>().health -= 5f;
		//	fall = true;
		//}
		//if ((rbody.position.y - GameObject.Find("Terrain").transform.position.y) < 1.7){
		//	fall = false;
		//}
		// rbody.AddForce (transform.up * speed * Input.GetAxis("Jump"));
		
		// comment out for sideways movement
		// rbody.AddForce (transform.right * speed * Input.GetAxis("Horizontal"));
		
		// TURNING
		transform.Rotate (0f, Input.GetAxis ("Horizontal") * turnSpeed, 0f);
		}

	}
}


