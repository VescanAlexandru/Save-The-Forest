using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class underwater : MonoBehaviour {
    public float underwaterLevel = 7;
    public Collider col;
   

    //The scene's default fog settings
    public GameObject cube;
    public GameObject cubeblack;
    void Awake()
    {
       
        
        cube.SetActive(false);
    }

    void Update()
    {
        if (transform.position.y < underwaterLevel)
        {
            cube.SetActive(true);
        }
        else
        {
            cube.SetActive(false);
        }
    }

}
