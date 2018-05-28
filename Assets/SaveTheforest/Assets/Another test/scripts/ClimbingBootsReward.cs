using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClimbingBootsReward : MonoBehaviour {

    public GameObject boots;
    public GameObject LitterStick;
    public int Reward = 15;
    public int Reward1 = 30;     
    public GameManager gameManager;
    public Shader shader1;
    public Shader shader2;
    public Renderer rend;
    // Use this for initialization


    public void OnTriggerEntry(Collider other)
    {
        if (other.gameObject.CompareTag("Button")&& gameManager.score != Reward)
        {
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else
                rend.material.shader = shader1;
            boots.SetActive(true);
        }
        if (other.gameObject.CompareTag("Button") && gameManager.score != Reward1)
        {
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else
                rend.material.shader = shader1;
            LitterStick.SetActive(true);
        }
    }
}
