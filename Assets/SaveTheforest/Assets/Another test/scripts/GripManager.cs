using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GripManager : MonoBehaviour {
	public Rigidbody Body;

	public Pull left;
	public Pull Right;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate () {
		var devicer = SteamVR_Controller.Input ((int)Right.controller.index);
		var devicel = SteamVR_Controller.Input ((int)left.controller.index);

		bool isGripped = left.canGrip || Right.canGrip;
        if (isGripped){
		if (left.canGrip && devicel.GetTouch (SteamVR_Controller.ButtonMask.Grip)) {
			Body.useGravity = false;
			Body.isKinematic = true;
			Body.transform.position += (left.prevPosition - left.transform.localPosition);
		}


			if (Right.canGrip && devicer.GetTouch (SteamVR_Controller.ButtonMask.Grip)) {
				Body.useGravity = false;
				Body.isKinematic = true;
				Body.transform.position += (Right.prevPosition - Right.transform.localPosition);
			} 

		}


		else {
			Body.useGravity = true;
			Body.isKinematic = false;

		}

		if (left.canGrip && devicel.GetTouchUp (SteamVR_Controller.ButtonMask.Grip) && isGripped == false){
			Body.useGravity = true;
			Body.isKinematic = false; 
			Body.velocity =(left.prevPosition - left.transform.localPosition) /Time.deltaTime;


		}
		if (Right.canGrip && devicer.GetTouchUp (SteamVR_Controller.ButtonMask.Grip) && isGripped == false){
			Body.useGravity = true;
			Body.isKinematic = false; 
			Body.velocity =(Right.prevPosition - Right.transform.localPosition) /Time.deltaTime;


		}
		left.prevPosition = left.controller.transform.localPosition;
		Right.prevPosition = Right.controller.transform.localPosition;
	}
}
