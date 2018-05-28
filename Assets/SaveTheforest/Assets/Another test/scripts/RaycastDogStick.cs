using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDogStick : MonoBehaviour {


    public float teleportRange;
    public LayerMask Topor;
    public GameObject Pipox;
    public GameObject[] Stick;
   
    public float radius = 2f;




    void Start()

    {
        Stick = GameObject.FindGameObjectsWithTag("Stick");
       


    }
    // Use this for initialization


    void Update()
    {

        RaycastHit hit;
        Ray objectray = new Ray(transform.position, Vector3.forward);

        if (Physics.SphereCast(objectray, radius, out hit, teleportRange, Topor))
        {
            Pipox.GetComponent<Fetch>().enabled = false;
            Pipox.GetComponent<COmehere>().enabled = true;
            Pipox.GetComponent<Seagull>().enabled = false;
            Debug.DrawRay(transform.forward, Vector3.up, Color.red);
            Debug.Log("pipox A BAtulll");


            if (hit.collider.gameObject.transform.parent = transform)
            {

                foreach (Transform child in transform)
                {

                    child.localPosition = new Vector3(0.00472F, 0.0515f, 0.018f);


                }
            }
        }




    }
}
