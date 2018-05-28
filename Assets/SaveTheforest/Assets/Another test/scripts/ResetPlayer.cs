using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

    public GameObject Player;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Player.transform.position = new Vector3(112.95f, 21.168f, 103.23f);
        }
    }
}
