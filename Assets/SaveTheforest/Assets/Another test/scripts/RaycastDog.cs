using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDog : MonoBehaviour
{

    public float teleportRange;
    public LayerMask RubishDog;
    
    public GameObject[] rubish;
    public GameObject[] BBQ;
    public GameObject[] Packet;
    public GameObject[] Beer;
    public GameObject Pipox;
    public float radius = 2f;
    



    void Start()

    {
        Packet = GameObject.FindGameObjectsWithTag("Packet");
        Beer = GameObject.FindGameObjectsWithTag("Beer");
        rubish = GameObject.FindGameObjectsWithTag("Rubish");
        BBQ = GameObject.FindGameObjectsWithTag("BBQ");
        Pipox.GetComponent<COmehere>();
        Pipox.GetComponent<Seagull>();


    }
    // Use this for initialization


    void Update()
    {

        RaycastHit hit;
        Ray objectray = new Ray(transform.position, Vector3.forward);
        gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
        if (Physics.SphereCast(objectray, radius, out hit, teleportRange, RubishDog))
        {

            Pipox.GetComponent<COmehere>().enabled = true;
            Pipox.GetComponent<Seagull>().enabled = false;
            Debug.DrawRay(transform.forward, Vector3.up, Color.red);
           
            


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

