using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntherockSound : MonoBehaviour
{
    public OnTriggerBoots Bots;
    public OntriggerEagle Eagle;
    public AudioSource Boots;
    public AudioSource Babyeagle;
    public AudioSource bootsandbaby;


    // Use this for initialization


    // Update is called once per frame

    void OnTriggerStay(Collider col)

    {


        if (Bots.bootsinactive == false && Eagle.eagleinactive == false)
        {
            if (col.CompareTag("Unttaged"))
            {
                bootsandbaby.Play();
            }
        }
        if (Bots.bootsinactive == true && Eagle.eagleinactive == false)
        {
            if (col.CompareTag("Untagged"))
            {
                Babyeagle.Play();
            }
        }
        if (Bots.bootsinactive == false && Eagle.eagleinactive == true)
        {
            if (col.CompareTag("Untagged"))
            {
                Boots.Play();
            }
        }
    }
}
               
           
    

