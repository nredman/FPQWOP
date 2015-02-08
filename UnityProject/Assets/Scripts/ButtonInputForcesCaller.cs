using UnityEngine;
using System.Collections;

public class ButtonInputForcesCaller : MonoBehaviour {
	
	//NEIL: you edit speed inside your function

	private bool isKeyDown = false;
	private bool isA = false;

	private float mouseX;
	private float mouseY;
	private Vector2 mouseMovements = new Vector2(0, 0);
	
	private float mouseWheelMovements;

	void FixedUpdate(){

		//Determines if you are controling left or right side
		if(Input.GetKey(KeyCode.A)){
			isA = true;
		} 
		else if(Input.GetKey(KeyCode.D)){
			isA = false;
			//Debug.Log("setting isA");
		}

		//Make a Vector2 of the mouse movement
		mouseX = Input.GetAxis("Mouse X");
		mouseY = Input.GetAxis("Mouse Y");
		mouseMovements.Set(mouseX, mouseY);

		//Gets scroll wheel usage
		mouseWheelMovements = Input.GetAxis("Mouse ScrollWheel");
	}

	//Call this to determine if we're working with the left or right leg
	public bool getLeftTrue(){
		return isA;
	}

	public bool getIsKeyDown(){
		if(Input.GetKey(KeyCode.A) || Input.GetKey (KeyCode.D)){
			isKeyDown = true;
		} else {
			isKeyDown = false;
		}
		return isKeyDown;
	}

	public Vector2 getMouseMovements(){
		return mouseMovements;
	}

	public float getScrollWheel(){
		return mouseWheelMovements;
	}
}
