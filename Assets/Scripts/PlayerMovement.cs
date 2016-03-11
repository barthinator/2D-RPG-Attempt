using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rbody;
	Animator anim;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update() {

		//getaxisraw returns true or false, if we were using getaxis this would allow floating point freedom
		//it animates towards the number you are trying to get too. axisraw just navigates to what you want
		Vector2 movementVector= new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		//Vector.zero is a vector with zero values
		if(movementVector != Vector2.zero){
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("inputX", movementVector.x);
			anim.SetFloat("inputY", movementVector.y);
		}
		else{
			anim.SetBool ("isWalking", false);
		}


		//Time delta time means that we move over 1 meter per 60 frames
		rbody.MovePosition (rbody.position + movementVector * Time.deltaTime);

	}
}
