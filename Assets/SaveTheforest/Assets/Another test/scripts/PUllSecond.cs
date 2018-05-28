using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUllSecond : MonoBehaviour {

    public GameObject Body;

    [HideInInspector]
    public Vector3 prevPosition;

    public SteamVR_TrackedObject controller;
   
    public bool canGrip;

	void Start () {

        prevPosition = controller.transform.position;
    
		
	}
	
	// Update is called once per frame
	void FIxUpdate () {
        var device = SteamVR_Controller.Input((int)controller.index);

        if( canGrip && device.GetTouch(SteamVR_Controller.ButtonMask.Grip))
        {
           // Body.useGravity = false;
            //Body.isKinematic = true;
            Body.transform.position += (prevPosition - controller.transform.localPosition);
        }
        else if( canGrip && device.GetTouchUp(SteamVR_Controller.ButtonMask.Grip))
        {
           
            //Body.useGravity = true;
            //Body.isKinematic = false;
           // Body.velocity = (prevPosition - controller.transform.localPosition) / Time.deltaTime;
            Body.transform.position += (prevPosition - controller.transform.localPosition);

        }
        else
        {
            //Body.useGravity = true;
            //Body.isKinematic = false;
        }
        prevPosition = controller.transform.localPosition;
	}
    void OnTriggerEnter()
    {
        canGrip = true;
    }
    void OnTriggerExit()
    {
        canGrip = false;
    }
}
