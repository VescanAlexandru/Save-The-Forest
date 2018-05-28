using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fetch : MonoBehaviour {
    public GameObject Bat;
    private Vector3 targetPoint;
    private Quaternion targetRotation;
    public float speed;
    public Transform targetBat;
    public Animator animator;
    public GameObject dog;
    public AnimationClip Run;









    void Start()
    {
        Bat = GameObject.FindWithTag("Stick");
        animator = GetComponent<Animator>();
        dog.GetComponent<COmehere>();
        dog.GetComponent<RaycastDog>();
        dog.GetComponent<Seagull>();
        dog.GetComponent<PipoxAiBehaviour>();



    }

    void Update()
    {
        targetPoint = new Vector3(targetBat.transform.position.x, transform.position.y, targetBat.transform.position.z) - transform.position;
        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetBat.position, step);
        dog.GetComponentInChildren<RaycastDog>().enabled = false;
        dog.GetComponent<PipoxAiBehaviour>().enabled = false;


    }
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")
        {

            animator.SetTrigger("Player");
            dog.GetComponent<COmehere>().enabled = false;
            print("A adus batul");
            StartCoroutine("Example");
            StartCoroutine("Example1");



        }
        else
        {
            animator.gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(1.2f);
        //animator.gameObject.GetComponent<Animator>().enabled = false;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = false;


    }
}
