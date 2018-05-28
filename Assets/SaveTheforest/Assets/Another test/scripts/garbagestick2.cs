using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class garbagestick2 : MonoBehaviour {

    public float speed = 0.5f;
    public bool shouldmove = true;
  
    public GameObject leftclaw;
    public GameObject rightclaw;

   


   
    void Shouldmove()
    {
               if (shouldmove)
            {
                leftclaw.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
                rightclaw.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
            }
      
    }
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Rubish")

        {
            leftclaw.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
            rightclaw.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
            shouldmove = false;
        }
        if (col.gameObject.tag == "claw")

        {
            leftclaw.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
            rightclaw.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
            shouldmove = false;
        }
    }
   
}
