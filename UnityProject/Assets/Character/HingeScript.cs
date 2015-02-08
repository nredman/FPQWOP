using UnityEngine;
using System.Collections;

public class HingeScript : MonoBehaviour {
	public Transform attachedTransform;
	private bool tensed = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q)){
			Loosen();
		} 
		if(Input.GetKey(KeyCode.E)){
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
