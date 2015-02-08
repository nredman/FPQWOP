using UnityEngine;
using System.Collections;

public class KillUI : MonoBehaviour {
	//Set this game object to the UI Canvas you want to close
	public GameObject ScreenToKill;

	//Invoke this function on the button click 
	public void RomoveUI(){			
		ScreenToKill.SetActive(false);
	}



}
