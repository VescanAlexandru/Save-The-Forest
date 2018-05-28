using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movieplay : MonoBehaviour
{

    public MovieTexture bird;
    public AudioSource playEagle;
    public GameObject screen;
    public GameManager scoreScript;




    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Nest"))
        {
            scoreScript.score = scoreScript.score + 1000;
            //col.transform.SetParent(gameObject.transform);
            //col.GetComponent<Rigidbody>().isKinematic = true;
          //  bird.Play();
          //  screen.SetActive(true);                 
           // StartCoroutine("Example");
        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(6f);
        Destroy(screen);
        playEagle.Stop();
    }
   
}

