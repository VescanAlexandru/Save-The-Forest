using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestScript : MonoBehaviour
{
    public GameObject eagle;
    public bool eagleinNestScript = false;
    public GameManager score;
    
        
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Rubish"))
        {
                    
            col.GetComponent<Rigidbody>().isKinematic = true;
            col.GetComponent<Rigidbody>().useGravity = false;
            eagleinNestScript = true;
            score.score = score.score + 1000;

        }
    }
}
