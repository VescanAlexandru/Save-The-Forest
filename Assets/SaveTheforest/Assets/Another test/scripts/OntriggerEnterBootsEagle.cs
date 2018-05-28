using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterBootsEagle : MonoBehaviour {
    public GameObject Stick;
    public ControllerInputManager scoreplus1;
    public ObjectMenuManager intscore;
    public GameObject StickIN;
    public GameObject StickOUT;
    public bool isstick=false;


    // Use this for initialization
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("MainCamera")&&isstick==true)
        {
            
           
            Stick.SetActive(false);
            scoreplus1.StickO1 = true;
            intscore.number[2] = intscore.number[2] + 2;
            StickIN.SetActive(true);
            StickOUT.SetActive(false);

        }
    }
}
