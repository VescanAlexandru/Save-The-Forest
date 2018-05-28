using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpull : MonoBehaviour {

    public Rigidbody  Body;    
    public SteamVR_TrackedObject controller;

    [HideInInspector]
    public Vector3 prevPos;
    public GameObject player;  
    public bool canGrip;
    public OnTriggerBoots Bots;
    public OntriggerEagle Eagle;
    
    
    // Use this for initialization
    void Start () {

       prevPos = controller.transform.position;
             
    }
	
    // Update is called once per frame

    void OnTriggerStay()

    {
        if (Bots.bootsinactive == true & Eagle.eagleinactive == true)
        {
            if (gameObject.CompareTag("Untagged"))
            {
                canGrip = true;
                player.GetComponent<MGripManager>().enabled = true;
                player.GetComponent<OncolisionGround>().enabled = false;
                player.GetComponent<Mpull>().enabled = true;
            }
        }
        else if (Bots.bootsinactive == false && Eagle.eagleinactive == false)
        {
            if (gameObject.CompareTag("Untagged"))
            {
                
                canGrip = false;
                player.GetComponent<Mpull>().enabled = false;
            }
        }

    }
    void OnTriggerExit()
    {
        canGrip = false;
        player.GetComponent<OncolisionGround>().enabled = false;
        player.GetComponent<MGripManager>().enabled = true;
       


    }
}
