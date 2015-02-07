using UnityEngine;
using System.Collections;

public class FootScript : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	// Use this for initialization
	void Start () {
		Move (new Vector3 (1, 1, 1));
	}
	
	// Update is called once per frame
	void Update () {

		Move (new Vector3 (0, 50, 2));
	}

	void Move(Vector3 mov){/*
		Vector3 targetVector = new Vector3 ();
		targetVector.x = transform.position.x + mov.x;
		targetVector.y = transform.position.y + mov.y;
		targetVector.z = transform.position.z + mov.z;
		transform.position = Vector3.SmoothDamp(transform.position, targetVector, ref velocity, smoothTime);
		*/
		rigidbody.AddForce (mov);
	}
}
