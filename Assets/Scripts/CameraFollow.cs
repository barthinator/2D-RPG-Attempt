using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Camera myCam;
	public float movementSpeed = .1f;
	public float cameraScale = 4f;

	// Use this for initialization
	void Start () {
		myCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		myCam.orthographicSize = (Screen.height / 100f) / cameraScale;

		if(target){
			//lerp(from, to, howfast);
			transform.position = Vector3.Lerp(transform.position, target.position, movementSpeed) + new Vector3(0,0,-10);
		}

	}
}
