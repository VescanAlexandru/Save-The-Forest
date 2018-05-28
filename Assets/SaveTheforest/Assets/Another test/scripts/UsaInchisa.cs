using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsaInchisa : MonoBehaviour {

    private Animator _animator;
    public AudioSource Usadeschisa;
    public GameObject usainauntru;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged")
        {

            Usadeschisa.Play();
            _animator.SetBool("UsaDeschisa", true);
            Wait();
            usainauntru.SetActive(false);
        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(0.00001f);
        _animator.SetBool("UsaDeschisa", false);
    }
    void UsaSetactie()
    {
        usainauntru.SetActive(true);
    }
}

