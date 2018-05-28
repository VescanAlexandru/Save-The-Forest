using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONtriggerPlusOaneBoots : MonoBehaviour {

       
    public ObjectMenuManager intscore;


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Untagged")
        {
            print("Score+1");           
            intscore.number[0] = intscore.number[0] + 2;

        }
    }

}


