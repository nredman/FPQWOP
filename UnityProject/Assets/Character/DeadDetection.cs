using UnityEngine;
using System.Collections;

public class DeadDetection : MonoBehaviour {
	public string LevelToLoad;
	// Use this for initialization
	public void goToNewLevel () {
		Application.LoadLevel(LevelToLoad);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.tag);
		if (collision.gameObject.tag == "floor"){
			goToNewLevel();
			Debug.Log ("head hit ground");
		}
	}
}
