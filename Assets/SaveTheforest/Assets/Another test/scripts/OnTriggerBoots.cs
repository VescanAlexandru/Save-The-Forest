using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerBoots : MonoBehaviour

{ 
    public GameObject boots;
    public ControllerInputManager scoreplus1;
    public bool bootsinactive;
    public ObjectMenuManager intscore;
    public GameObject textininventroyboots;
    public GameObject textoutinventroyboots;
    


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "MainCamera")
        {
            
            boots.SetActive(false);
            bootsinactive = true;
            scoreplus1.bocanciactivi = true;
            intscore.number[0] = intscore.number[0] + 2;
            textininventroyboots.SetActive(true);
            textoutinventroyboots.SetActive(false);

        }
    }

}
