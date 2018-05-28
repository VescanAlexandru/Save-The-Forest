using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinBagScore : MonoBehaviour
{ 
    public GameManager scoreScript;
    
 
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Rubish"))
        {
            scoreScript.score = scoreScript.score + 15;
            scoreScript.litterLeft = scoreScript.litterLeft - 1;
            col.tag = "After";


        }
        if (col.gameObject.CompareTag("BBQ"))
        {
            scoreScript.score = scoreScript.score  +55;           
            scoreScript.litterLeft = scoreScript.litterLeft - 1;
            col.tag = "After";


        }

        if (col.gameObject.CompareTag("Beer"))
        {
            scoreScript.score = scoreScript.score + 75;
            scoreScript.litterLeft = scoreScript.litterLeft - 1;
            col.tag = "After";



            
        }
        if (col.gameObject.CompareTag("Packet"))
        {
            scoreScript.score = scoreScript.score + 25;
            scoreScript.litterLeft = scoreScript.litterLeft - 1;
            col.tag = "After";

        }
    }
   

}
   

