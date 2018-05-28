using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int score;
    public int litterLeft=8;
    public MovieTexture cleanforest;
    public AudioSource cleanforestsound;
    public GameObject Screen1;
    public NestScript eagleinnest;   
    public GameObject buutonright;
    public Text right;
    




   

    public void  Update()
    {


        if (litterLeft == 0 && eagleinnest.eagleinNestScript == true )
        {
            cleanforest.Play();
            cleanforestsound.Play();
            Screen1.SetActive(true);
            StartCoroutine("Example");          
            buutonright.SetActive(true);
            right.text = "Congratulation you won the Game\n EXIT GAME";                            

        }
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(87f);
        cleanforest.Stop();
        cleanforestsound.Stop();
        Destroy(Screen1);
       


    }
   


}

