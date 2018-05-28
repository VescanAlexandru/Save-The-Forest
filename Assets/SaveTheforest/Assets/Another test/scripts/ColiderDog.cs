using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderDog : MonoBehaviour
{

    public List<Rigidbody> sacada;
    public Animator animator;

    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")

        {

            animator.Play("PipoxRig|Wait");
            foreach (Rigidbody sacada in sacada)
            {
                transform.DetachChildren();
                sacada.isKinematic = false;
                sacada.useGravity = true;
                

            }


            animator.Play("PipoxRig|Wait");


        }
    }
    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.name == "Player")

        {


            foreach (Rigidbody sacada in sacada)
            {
                transform.DetachChildren();
                sacada.isKinematic = true;
                sacada.useGravity = false;

            }
        }
    }
}
