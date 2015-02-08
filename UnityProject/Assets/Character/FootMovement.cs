using UnityEngine;
using System.Collections;

public class FootMovement : MonoBehaviour {

	public GameObject inputScriptLocation;
	ButtonInputForcesCaller BIFC;
	// Use this for initialization
	void Start () {
		bool leftOrRight = false;

		//ButtonInputForcesCaller otherScript = GetComponent<ButtonInputForcesCaller>();

		GameObject otherObject = GameObject.Find("Torso");
		ButtonInputForcesCaller otherScript = otherObject.GetComponent<ButtonInputForcesCaller>();
		leftOrRight = otherScript.getLeftTrue();
		Debug.Log(leftOrRight);

		BIFC = otherScript;

	}
	
	// Update is called once per frame
	void Update () {
		if(BIFC.getIsKeyDown() == true){
			Move(BIFC.getMouseMovements());
		}
	}

	void Move(Vector2 mov){
		Vector3 targetVector = new Vector3 ();
		targetVector.x = mov.x;
		targetVector.y = 0;
		targetVector.z = mov.y;
		rigidbody.AddForce (targetVector);
	}
}




