using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numberplay25 : MonoBehaviour {

  //  public Animator anim;
    public GameObject number;
    public GameObject Arrow;
    // public GameObject number0;

    void Start()
    {

        //anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Untagged")
        {

            // anim.Play("test"); //set animation name here
            number.SetActive(true);
            Arrow.SetActive(false);



        }
        else
        {
            //      number.SetActive(false);

        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Untagged")
        {

            // anim.Play("test"); //set animation name here
            number.SetActive(true);
            Arrow.SetActive(false);


        }
        else
        {
            //  number.SetActive(false);

        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Untagged")
        {

            //  anim.Play("test"); //set animation name here
            number.SetActive(false);
            Arrow.SetActive(false);


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

