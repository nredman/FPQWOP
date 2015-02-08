using UnityEngine;
using System.Collections;

public class UpperLegScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Lift (Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		Lift (Time.deltaTime);
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
