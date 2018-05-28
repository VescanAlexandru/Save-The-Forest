using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectMenuManager : MonoBehaviour
{

    public List<GameObject> objectList;
    public List<GameObject> objectListPrefabs;
    public GameObject babyeagle;
    public GameObject boots;
    public GameObject bootsprefab;
    public GameObject babyeagleprefab;
    public GameObject Stick;
    public GameObject Stickprefab;
    public int[] number;
    public ControllerInputManager input;
    public int currentObject = 0;
    public GameManager score;
    public GameObject OutofInventoryBoots;
    public GameObject InInventoryBoots;
    public GameObject textininventroStick;
    public GameObject textoutinventroyStick;
    public GameObject textininventroyeagle;
    public GameObject textoutinventroyeagle;



    void Start()
    {

        foreach (Transform child in transform)
        {
            objectList.Add(child.gameObject);
        }

    }
    void Update()
    {

    }

    public void MenuLeft()
    {

        objectList[currentObject].SetActive(false);
        currentObject--;

        {
            if (currentObject < 0)
            {
                currentObject = objectList.Count - 1;


               

            }
            else if (currentObject < 0)
            {
                currentObject = objectList.Count - 1;



            }

            objectList[currentObject].SetActive(true);

            if (currentObject < 0)
            {
                currentObject = objectList.Count - 1;





            }
            else if (currentObject < 0)
            {
               


            }
            objectList[currentObject].SetActive(true);
        }
    }


    public void MenuRight()
    {

        objectList[currentObject].SetActive(false);
        currentObject++;

        if (currentObject > objectList.Count - 1)
        {
            currentObject = 0;
        }
        objectList[currentObject].SetActive(true);

    }


    public void SpwanCurrentObject()
    {

        int count = number[currentObject];
        if (number[0] == 0)
        {
            if (currentObject == 0)
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                Quaternion objectListRotation = objectList[currentObject].transform.rotation;
                if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
                {
                    input.Bocanci.SetActive(false);
                    objectListRotation = Quaternion.Euler(newRotation);
                    InInventoryBoots.SetActive(false);
                    OutofInventoryBoots.SetActive(true);

                }


                // number[currentObject] = count - 1;
            }
        }
        if (number[0] >= 1)
        {
            if (currentObject == 0)
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                Quaternion objectListRotation = objectList[currentObject].transform.rotation;
                if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
                {
                    input.Bocanci.SetActive(true);
                    objectListRotation = Quaternion.Euler(newRotation);
                    InInventoryBoots.SetActive(false);
                    OutofInventoryBoots.SetActive(true);

                }


                // number[currentObject] = count - 1;
            }
        }
        if (number[1] >= 1)
        {
            if (currentObject == 1)
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                Quaternion objectListRotation = objectList[currentObject].transform.rotation;
                if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
                {
                    input.puivultur.SetActive(true);
                    objectListRotation = Quaternion.Euler(newRotation);
                    textininventroyeagle.SetActive(false);
                    textoutinventroyeagle.SetActive(true);

                }

            }
        }
       // if (number[1] == 0)
       // {
          //  if (currentObject == 1)
          //  {
             //   Vector3 newRotation = new Vector3(0, 0, 0);
              //  Quaternion objectListRotation = objectList[currentObject].transform.rotation;
              //  if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
              //  {
               //     input.puivultur.SetActive(false);
               //     objectListRotation = Quaternion.Euler(newRotation);

              //  }

           // }
      //  }
        if (number[2] == 0)
        {
            if (currentObject == 2)//&& score.score>=500)
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                Quaternion objectListRotation = objectList[currentObject].transform.rotation;
                if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
                {
                    input.StickO.SetActive(false);
                    objectListRotation = Quaternion.Euler(newRotation);
                    textininventroStick.SetActive(false);
                    textoutinventroyStick.SetActive(true);
                }
                // number[currentObject] = count -1;
            }

        }
        if (number[2] >= 1)
        {

            if (currentObject == 2)//&& score.score>=500)
            {
                Vector3 newRotation = new Vector3(0, 0, 0);
                Quaternion objectListRotation = objectList[currentObject].transform.rotation;
                if (objectList[currentObject].transform.eulerAngles != Vector3.zero)
                {
                    input.StickO.SetActive(true);
                    objectListRotation = Quaternion.Euler(newRotation);
                    textininventroStick.SetActive(false);
                    textoutinventroyStick.SetActive(true);

                }
                // number[currentObject] = count -1;
            }

        }
    }
}






