using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEagle : MonoBehaviour {

    public GameObject eagle;
    public ControllerInputManager scoreplus1;
    public bool eagleinactive;
    public ObjectMenuManager intscore;
    public GameObject EagleIN;
    public GameObject EagleOUT;

    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "MainCamera")
        {
            
            eagleinactive = true;
            eagle.SetActive(false);
           scoreplus1.bocanciactivi = true;
            intscore.number[1] = intscore.number[1] + 1;
            EagleIN.SetActive(true);
            EagleOUT.SetActive(false);
        }
    }
}
