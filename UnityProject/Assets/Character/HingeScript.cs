using UnityEngine;
using System.Collections;

public class HingeScript : MonoBehaviour {

	public Transform attachedTransform;
	private bool tensed = true;
	public bool isLeft = false;
	ButtonInputForcesCaller BIFC;
	// Use this for initialization
	void Start () {
		GameObject otherObject = GameObject.Find("Torso");
		ButtonInputForcesCaller otherScript = otherObject.GetComponent<ButtonInputForcesCaller>();
		BIFC = otherScript;
	}
	
	// Update is called once per frame
	void Update () {
		if((isLeft && BIFC.getLeftTrue()) || !isLeft && BIFC.getRightTrue()){
			Loosen();
		} 
		else if(isLeft && !BIFC.getIsKeyDown() || !isLeft && !BIFC.getIsKeyDown()){
			Tense();
		} 
	}

	void Loosen() {
		GetComponent<HingeJoint> ().useSpring = false;
		tensed = false;
	}

	void Tense() {
		if (!tensed) {
			JointSpring tempSpring = GetComponent<HingeJoint> ().spring;
			tempSpring.targetPosition = GetComponent<HingeJoint>().angle;
			GetComponent<HingeJoint> ().spring = tempSpring;
			GetComponent<HingeJoint> ().useSpring = true;
			tensed = true;
		}
	}
}
