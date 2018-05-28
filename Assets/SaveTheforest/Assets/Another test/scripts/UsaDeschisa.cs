using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsaDeschisa : MonoBehaviour {

    private Animator _animator;
    public AudioSource Usadeschisa;
    public AudioSource Usainchisa;
    
    
    // Use this for initialization
    void Start() {
        _animator = GetComponent<Animator>();
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged")
        {
           
            
            _animator.SetBool("UsaDeschisa", true);                       
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Untagged")
        {


            _animator.SetBool("UsaDeschisa", true);
        }
    }
    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Untagged")
        {          
            _animator.SetBool("UsaDeschisa", false);
            
        }
    }
    void UsainchisaPlay()
    {
        Usainchisa.Play();
    }
    void UsaDeschisaPlay()
    {
        Usadeschisa.Play();
    }
}
 

	

