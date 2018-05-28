using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicWinnersetactive : MonoBehaviour {

    public GameManager score;
    


	// Use this for initialization
	
	// Update is called once per frame
	
        void Update ()
     {
            foreach (Transform children in this.transform)
            {
                if (score.litterLeft == 0)
                {
                children.gameObject.SetActive(true);
               
                }
                else if (score.score < 2500)
                {
                    children.gameObject.SetActive(false);
                
            }
            }

        }
}
