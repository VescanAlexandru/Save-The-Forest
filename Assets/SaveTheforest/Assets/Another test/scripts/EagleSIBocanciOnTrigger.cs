using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSIBocanciOnTrigger : MonoBehaviour {

    public GameObject eagle;
    public ControllerInputManager scoreplus1;
    

    // Use this for initialization
    void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("Main"))
        {
            print("AtingeSoloCameraScriptSeparatEagle");

           // eagle.SetActive(false);
          //  scoreplus1.bocanciactivi = true;
        }
    }
}
