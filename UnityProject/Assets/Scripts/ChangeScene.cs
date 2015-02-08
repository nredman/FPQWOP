using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	 
	public string LevelToLoad;
	// Use this for initialization
	public void goToNewLevel () {
		Application.LoadLevel(LevelToLoad);
	}
}
