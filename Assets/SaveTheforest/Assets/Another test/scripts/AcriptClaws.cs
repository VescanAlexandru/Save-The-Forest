using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcriptClaws : MonoBehaviour
{

    private void Start()
    {
        gameObject.GetComponent<Rigidbody>();


    }
    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Rubish"|| col.gameObject.tag == "BBQ" || col.gameObject.tag == "Packet"|| col.gameObject.tag == "Beer")

        {
            col.transform.SetParent(gameObject.transform);
       gameObject.GetComponent<Rigidbody>().isKinematic = true;
                                                
        }    
    }

  
 }



