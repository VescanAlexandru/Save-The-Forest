using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public GameManager gameManager;
	public int oldScore;
    public int oldLitter;

	public Text text;
    public Text LitterText;

    void Update()
    {
        if (gameManager.score != oldScore)
        {
            oldScore = gameManager.score;
            ChangeScoreUI();
        }
        if (gameManager.litterLeft != oldLitter)
        {
            oldLitter = gameManager.litterLeft;
            ChangeScoreUILitter();

        }
    }
		private void ChangeScoreUI()
    {		
			text.text = "Score: " + gameManager.score.ToString();
        LitterText.text = "Litter Left : " + gameManager.litterLeft.ToString();
		}
    private void ChangeScoreUILitter()
    {        
        LitterText.text = "Litter Left : " + gameManager.litterLeft.ToString();
    }
}

