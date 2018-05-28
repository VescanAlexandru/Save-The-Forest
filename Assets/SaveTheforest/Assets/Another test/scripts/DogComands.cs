using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using System.Text;



public class DogComands : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
    public Animator anim;







    void Start()
    {
        keywords.Add("Paw", () => { Paw(); });
        keywords.Add("sit", () => { Sit(); });
        keywords.Add("Come Here", () => { ComeHere(); });
        keywords.Add("Help", () => { Help(); });
        keywords.Add("Wait", () => { Wait(); });
        keywords.Add("Go Play", () => { Go(); });
        keywords.Add("Good Boy", () => { GoodBoy(); });
        keywords.Add("bring ", () => { Fetch(); });
        
        keywords.Add("fetch", () => { Fetch(); });


        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += keywordRecognizerOnPraseRecognized;
        keywordRecognizer.Start();
        anim = GetComponent<Animator>();

        gameObject.GetComponent<RaycastDogStick>();
        gameObject.GetComponent<Fetch>();
        gameObject.GetComponent<Seagull>();
        gameObject.GetComponent<PipoxAiBehaviour>();
        gameObject.GetComponentInChildren<RaycastDog>();
        gameObject.GetComponentInChildren<BoxCollider>();
    }


    void keywordRecognizerOnPraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }


    void Paw()
    {
        
        anim.Play("PipoxRig|Paw");
        anim.Play("PipoxRig|Paw 0");
        gameObject.GetComponent<RaycastDogStick>().enabled = false;
        gameObject.GetComponent<Fetch>().enabled = false;
        gameObject.GetComponent<Seagull>().enabled = false;
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;
        Debug.Log("PAw");
    }
    void Sit()
    {
        anim.Play("PipoxRig|Sit");
        
        anim.gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<Seagull>().enabled = false;
        gameObject.GetComponent<COmehere>().enabled = false;
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;


    }
    void ComeHere()
    {
        anim.Play("PipoxRig|Run");
        gameObject.GetComponent<COmehere>().enabled = true;      
        gameObject.GetComponent<Seagull>().enabled = false;
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;
        gameObject.GetComponentInChildren<RaycastDog>().enabled = false;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = true;



    }
    void Help()
    {
        gameObject.GetComponent<Seagull>().enabled = true;
        gameObject.GetComponentInChildren<RaycastDog>().enabled = true;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
        anim.Play("PipoxRig|Run");
        anim.gameObject.GetComponent<Animator>().enabled = true;
        
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;
        gameObject.GetComponent<COmehere>().enabled = false;
    }
    void Wait()
    {
        anim.Play("PipoxRig|Wait");
        gameObject.GetComponent<Seagull>().enabled = false;
        gameObject.GetComponentInChildren<RaycastDog>().enabled = false;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
        gameObject.GetComponent<COmehere>().enabled = false;
      
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;
    }
    void Go()
    {
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = true;
    }

    void GoodBoy()
    {
        anim.Play("PipoxRig|GoodBoy");
        gameObject.GetComponent<Seagull>().enabled = false;
        
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;

    }
    void Fetch()
    {
        anim.Play("PipoxRig|Run");
        gameObject.GetComponent<RaycastDogStick>().enabled = true;
        gameObject.GetComponent<Fetch>().enabled = true;
        gameObject.GetComponent<Seagull>().enabled = false;
        gameObject.GetComponent<PipoxAiBehaviour>().enabled = false;
        Debug.Log("PAwMergeFetch");
    }
   
}





