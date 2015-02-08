using UnityEngine;
using System.Collections;

public class UpperLegScript : MonoBehaviour {
	// Use this for initialization
	private ButtonInputForcesCaller BIFC;
	public bool isLeft  = false;
	public float moveSpeed = 10;
	private bool shiftedRight = false;
	private bool shiftedLeft = false;
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
			else if(!isLeft && BIFC.getRightTrue()){
				Lift(BIFC.getScrollWheel() * moveSpeed);
			}

			else if(isLeft && BIFC.getRightTrue() && !shiftedLeft){
				Debug.Log("shifting left");
				shiftedLeft = true;
				shiftedRight = false;
				ShiftWeight(-20f);
			}
			else if(!isLeft && BIFC.getLeftTrue() && !shiftedRight){
				Debug.Log("shifting right");
				shiftedLeft = false;
				shiftedRight = true;
				ShiftWeight(20f);
			}
			if(isLeft && BIFC.getLeftTrue() && shiftedLeft){
				Debug.Log("shifting back from left");
				shiftedLeft = false;
				shiftedRight = true;
				ShiftWeight(20f);
			}
			else if(!isLeft && BIFC.getRightTrue() && shiftedRight){
				Debug.Log("shifting back from right");
				shiftedLeft = true;
				shiftedRight = false;
				ShiftWeight(-20f);
			}
		}
		//Lift (Time.deltaTime);
	}

	void Lift(float amount){
		Vector3 eulerRot = this.GetComponent<ConfigurableJoint> ().targetRotation.eulerAngles;
		eulerRot.x += amount;
		Quaternion rot = Quaternion.Euler (eulerRot);
		GetComponent<ConfigurableJoint> ().targetRotation = rot;
	}

	void ShiftWeight(float amount){
		Vector3 eulerRot = this.GetComponent<ConfigurableJoint> ().targetRotation.eulerAngles;
		eulerRot.y += amount;
		Quaternion rot = Quaternion.Euler (eulerRot);
		GetComponent<ConfigurableJoint> ().targetRotation = rot;
	}
}
