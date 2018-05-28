using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;

public class COmehere : MonoBehaviour
{
    public GameObject Target;
    private Vector3 targetPoint;
    private Quaternion targetRotation;
    public float speed;
    public Transform target;
    public Animator animator;
    public GameObject dog;
    public AnimationClip Run;









    void Start()
    {
        Target = GameObject.FindWithTag("Player");
        animator = GetComponent<Animator>();
        dog.GetComponent<COmehere>();
        dog.GetComponent<RaycastDog>();
        dog.GetComponent<Seagull>();
        dog.GetComponent<PipoxAiBehaviour>();



    }

    void Update()
    {
        targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;
        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        dog.GetComponentInChildren<RaycastDog>().enabled = false;
        dog.GetComponent<PipoxAiBehaviour>().enabled=false;


    }
    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.name == "Player")
        {
            
                animator.SetTrigger("Player");
               dog.GetComponent<COmehere>().enabled = false;
               
            // StartCoroutine ("Example");
            // StartCoroutine("Example1");
             gameObject.GetComponentInChildren<BoxCollider>().enabled = true;



        }
        else
        {
          //  animator.gameObject.GetComponent<Animator>().enabled = true;
           // gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
        }
    }
  private  void OnTriggerStay(Collider col)
    {

        if (col.gameObject.name == "Player")
        {
            StopCoroutine("Example");
            StopCoroutine("Example1");
            
        }
    }
    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(1.2f);
      //  animator.gameObject.GetComponent<Animator>().enabled = false;
       gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
       
    
    }
    IEnumerator Example1()
    {
        yield return new WaitForSeconds(4f);
     // animator.gameObject.GetComponent<Animator>().enabled = true;
       // dog.GetComponent<Seagull>().enabled = true;
     //  gameObject.GetComponentInChildren<BoxCollider>().enabled = true;



    }

}


        
             
      