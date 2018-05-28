using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour {


    public Rigidbody Body;

    [HideInInspector]
    public Vector3 prevPosition;

    public SteamVR_TrackedObject controller;

    public bool canGrip;


    // Use this for initialization
    void Start () {
        prevPosition = controller.transform.position;

    }

    // Update is called once per frame
   
        
    void OnTriggerEnter()
    {
        canGrip = true;
        

    }
    void OnTriggerExit()
    {
        canGrip = false;
        
    }
}
