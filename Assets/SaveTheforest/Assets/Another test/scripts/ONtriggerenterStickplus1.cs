using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONtriggerenterStickplus1 : MonoBehaviour {
    public ObjectMenuManager intscore;


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Untagged")
        {
            print("Score+1");
            intscore.number[2] = intscore.number[2] + 2;

        }
    }
}
