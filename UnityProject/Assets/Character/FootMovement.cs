using UnityEngine;
using System.Collections;

public class FootMovement : MonoBehaviour {

	public GameObject inputScriptLocation;
	ButtonInputForcesCaller BIFC;
	public bool isLeft = false;
	public float moveSpeed = 10;
	// Use this for initialization
	void Start () {

		GameObject otherObject = GameObject.Find("Torso");
		ButtonInputForcesCaller otherScript = otherObject.GetComponent<ButtonInputForcesCaller>();
		BIFC = otherScript;

	}
	
	// Update is called once per frame
	void Update () {
		//case where is the left foot and the left key is down
		if(isLeft && BIFC.getLeftTrue()){
			Move(BIFC.getMouseMovements() * moveSpeed);
		}
		//case where is not left foot and is the right key down
		else if(!isLeft && BIFC.getRightTrue()){
			Move(BIFC.getMouseMovements() * moveSpeed);
			Debug.Log("Still in isRight");
		}
	}

	void Move(Vector2 mov){
		Vector3 targetVector = new Vector3 ();
		targetVector.x = mov.x;
		targetVector.y = 0;
		targetVector.z = -mov.y;
		targetVector = transform.rotation * targetVector;
		rigidbody.AddForce (targetVector);
	}
}




