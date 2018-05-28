using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSoundPlay : MonoBehaviour
{
    public AudioSource dogrun;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")

        {
            dogrun.Play();
        }
    }
}
