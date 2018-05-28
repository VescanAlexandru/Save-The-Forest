using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipoxAiBehaviour : MonoBehaviour
{

    public Animator animator;
    public GameObject Dog;

    void Start()
    {
        animator = GetComponent<Animator>();
        Dog.GetComponent<Seagull>();
        Dog.GetComponent<RaycastDog>();

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Example");
        gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
       


    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(1.4f);
        Dog.GetComponent<Seagull>().enabled = true;
        Dog.GetComponent<COmehere>().enabled = false;
        animator.Play("PipoxRig|Run");
     //   Dog.GetComponent<RaycastDog>().enabled = false;


    }
}
