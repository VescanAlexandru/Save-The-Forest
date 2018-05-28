using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterBinnUnparent : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            other.transform.DetachChildren();
           
        }
    }
}
