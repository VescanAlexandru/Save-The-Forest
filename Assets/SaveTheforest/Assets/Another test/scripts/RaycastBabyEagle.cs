using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastBabyEagle : MonoBehaviour
{

    public float teleportRange = 40f;
    public LayerMask Restricted;
    public AudioSource Babyeagle;

    void Update()
    {

        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100
            ;
        Debug.DrawRay(this.transform.position, Vector3.forward, Color.green);

        if (Physics.Raycast(transform.position, (forward), out hit, teleportRange, Restricted))
        {
            Babyeagle.Play();
            StartCoroutine("Example");

        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(6f);
        Destroy(Babyeagle);

    }
}
