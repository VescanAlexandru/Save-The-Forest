using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROCKgravity : MonoBehaviour {
    public Rigidbody piatra;
    public GameObject Glass;

    // Use this for initialization
    void Start() {
        piatra = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   

        void OnCollisionEnter(Collision collision)
	{
        if (gameObject.CompareTag("Glass"))
        {
            piatra.isKinematic = false;
            piatra.useGravity = true;
        }
        
    }
}
