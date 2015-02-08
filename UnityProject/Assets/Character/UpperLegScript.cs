using UnityEngine;
using System.Collections;

public class UpperLegScript : MonoBehaviour {
	// Use this for initialization
	private ButtonInputForcesCaller BIFC;
	public bool isLeft  = false;
	public float moveSpeed = 10;
	void Start () {
		Lift (Time.deltaTime);

		GameObject otherObject = GameObject.Find("Torso");
		ButtonInputForcesCaller otherScript = otherObject.GetComponent<ButtonInputForcesCaller>();
		BIFC = otherScript;
	}
	
	//Update is called once per frame
	void Update () {
		if(BIFC.getIsKeyDown() == true){
			//case where is the left foot and the left key is down
			if(isLeft && BIFC.getLeftTrue()){
				Lift(BIFC.getScrollWheel() * moveSpeed);
			}
			//case where is not left foot and is the right key down
			else if(!isLeft && !BIFC.getLeftTrue()){
				Lift(BIFC.getScrollWheel() * moveSpeed);
			}
		}
		//Lift (Time.deltaTime);
	}

	void Lift(float amount){
		Debug.Log (amount);
		Vector3 eulerRot = this.GetComponent<ConfigurableJoint> ().targetRotation.eulerAngles;
		eulerRot.x += amount;
		Debug.Log (eulerRot.ToString());
		Quaternion rot = Quaternion.Euler (eulerRot);
		Debug.Log (rot.ToString ());
		GetComponent<ConfigurableJoint> ().targetRotation = rot;
	}
}
