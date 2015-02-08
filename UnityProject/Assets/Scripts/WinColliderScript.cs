using UnityEngine;
using System.Collections;

public class WinColliderScript : MonoBehaviour {

	public string sceneToChangeTo;

	void OnTriggerEnter(Collider hit) {

		//Debug.Log("Inside OnCollisionEnter" + hit);

		if(hit.gameObject.name == "End Game Box"){
			//Debug.Log("Well you hit the box");
			Application.LoadLevel(sceneToChangeTo);

		}

	}
}
