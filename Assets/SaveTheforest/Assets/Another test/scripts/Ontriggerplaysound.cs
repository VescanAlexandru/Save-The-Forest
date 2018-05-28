using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggerplaysound : MonoBehaviour
{
    public LayerMask Player;
    public AudioSource pipoxruning;
    void Update()
    {



        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100.0f, Player))
        {
            print("Found an object - distance: " + hit.distance);
            pipoxruning.Play();
        }
    }
}
