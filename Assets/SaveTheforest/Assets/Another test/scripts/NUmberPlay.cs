using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUmberPlay : MonoBehaviour {

   // public Animator anim;
    public GameObject number;
    public GameObject Arrow;
   // public GameObject number0;

    void Start()
    {
       
       // anim = GetComponent<Animator>();
    }
    
    void OnTriggerEnter(Collider col)
    {
        if ( col.gameObject.tag == "Untagged")
        {
                       
           // anim.Play("test"); //set animation name here
           number.SetActive(true);
            Destroy(Arrow);
           
           
        }
        if (col.gameObject.tag == "Nest")
        {
            //      number.SetActive(false);
            number.SetActive(false);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Untagged")
        {

            number.SetActive(true);
        }
        if (col.gameObject.tag == "Nest")
        {

            number.SetActive(false);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if ( col.gameObject.tag == "Untagged")
        {

          //  anim.Play("test"); //set animation name here
            number.SetActive(false);
           

        }
        else
        {
        //    number.SetActive(false);
            
        }
    }


    public void TriggerAsta()
   {     
         number.SetActive(false);
       // number0.SetActive(false);
       
    }
   


}
