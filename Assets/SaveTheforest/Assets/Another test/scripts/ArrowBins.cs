using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBins : MonoBehaviour {

    public GameObject Arrow;
   

   

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Untagged")
        {          
           
            Arrow.SetActive(false);

        }
       
    }
  
}
