using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerlitterLeft : MonoBehaviour
{
    public GameManager LitterLeft;
   public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Respawn" )
        {

            {
                LitterLeft.litterLeft = LitterLeft.litterLeft - 1;
                other.GetComponent<Rigidbody>().isKinematic = true;
               other.transform.SetParent(gameObject.transform);

            }
        }


    }
   public  void OnTriggerStay(Collider other)
    {
        if (other.tag == "Respawn")
        {

            {
                LitterLeft.litterLeft = LitterLeft.litterLeft  -0;
                other.GetComponent<Rigidbody>().isKinematic = true;

            }
        }
    }
   public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Respawn")
        {

            {
                LitterLeft.litterLeft = LitterLeft.litterLeft - 0;
                other.GetComponent<Rigidbody>().isKinematic = true;

            }
        }
    }
}

