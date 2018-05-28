using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinBagAttachObjects : MonoBehaviour {

    
   
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {

        if (other.tag == "After")
        {
          
            {
                other.transform.SetParent(gameObject.transform);
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.GetComponent<Rigidbody>().useGravity = false;


            }
        }


    }
    void OnTriggerStay(Collider other)
    {

         if (other.tag == "After")
            {

            {
                other.transform.SetParent(gameObject.transform);
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.GetComponent<Rigidbody>().useGravity = false;


            }
        }


    }
}
