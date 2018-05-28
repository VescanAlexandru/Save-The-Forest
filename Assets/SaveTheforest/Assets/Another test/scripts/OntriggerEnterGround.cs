using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterGround : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Ground")

        {
            print("atinge Pamantul");

        }
    }
}
