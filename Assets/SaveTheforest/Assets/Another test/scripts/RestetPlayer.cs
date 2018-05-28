using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestetPlayer : MonoBehaviour {

       public GameObject Player;

        void OnTriggerEnter(Collider col)
    {
        if(gameObject.CompareTag("Player"))
        {
            Player.transform.position = new Vector3(112.95f, 21.23f, 103.23f);
        }
    }
}
