using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncolisionGround : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody body;
    public GameObject Player;

    void Start()
    {
        Player.GetComponent<MGripManager>().enabled = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("contact");
            body.isKinematic = true;
            body.useGravity = false;
            Player.GetComponent<MGripManager>().enabled = false;
        }
    }
    
}
