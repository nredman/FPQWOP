using UnityEngine;
using System.Collections;

public class MoveUI : MonoBehaviour {

	//public GameObject currentScreen;
	public GameObject nextScreen;

	// Use this for initialization
	public void NextUI(){
		nextScreen.SetActive(true);
	}
}
