using UnityEngine;
using System.Collections;

public class ButtonInputForcesCaller : MonoBehaviour {
	/* For me to do:
		-Script
			-Takes input in so arrow keys A and D
			-From those arrow keys */

	//NEIL: you edit speed inside your function

	private bool left;

	private float mouseX;
	private float mouseY;
	private Vector2 mouseMovements = new Vector2(0, 0);
	
	private float mouseWheelMovements;

	void FixedUpdate(){

		//Determines if you are controling left or right side
		if(Input.GetKey(KeyCode.A)){
			left = true;
		} 
		else if(Input.GetKey(KeyCode.D)){
			left = false;
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
		return left;
	}

	public Vector2 getMouseMovements(){
		return mouseMovements;
	}

	public float getScrollWheel(){
		return mouseWheelMovements;
	}
}
