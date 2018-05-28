using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskinematicTherubish : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rubish;
	void Start () {

        rubish = GetComponent<Rigidbody>();
		
	}

    // Update is called once per frame
    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "claw")

        {


            rubish.isKinematic = false;


        }
    }
}
