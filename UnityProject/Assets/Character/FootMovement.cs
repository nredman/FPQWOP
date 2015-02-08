using UnityEngine;
using System.Collections;

public class FootMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Move(Vector2 mov){
		Vector3 targetVector = new Vector3 ();
		targetVector.x = mov.x;
		targetVector.y = 0;
		targetVector.z = mov.y;
		rigidbody.AddForce (targetVector);
	}
}




