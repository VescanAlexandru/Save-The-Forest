using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ControllerInputManager : MonoBehaviour
{

    private SteamVR_TrackedObject trackedObj;
    public SteamVR_Controller.Device device;
    public GameObject leftController;
    public GameObject rightController;
    //...Deliver...//
    public GameObject boots;
    public GameObject LitterStic;
    public int Reward = 100;
    public int Reward1 = 200;
     public int Myback = 500;
    public int Gamefinale=0;
    public Renderer Climbing;
    public Renderer Litter1;
    public Material mat1;
    public Material Enterreward;
    public Material DecizionLeft;
    public Material DecizionRight;
    public Material DecizionExit;
    
    public GameManager gameManager;
    public AudioSource bootsdelivered;
    public AudioSource LitterSticdelivered;
   // public AudioSource Mybackplay;
    public BinBagScore binbagcount;

    //......//
    public TeleportVive teleportActive;
    public GameObject sStick;
    public GameObject ClimbingButton;
    public GameObject Littertickbutton;
    public GameObject number15;
    public Renderer paneldecizLeftOnentry;
    public Renderer paneldecizRightOnentry;
    public GameObject paneldecizLeftOnentry1;
    public GameObject paneldecizRightOnentry1;
    public GameObject panelIsNot;
    public Text RewardhasbeenclaimedLitter;
    public Text RewardhasbeenclaimedBoots;
    









    //..... Grabbing and throwing.....//
    public float throwForce = 1.5f;
    public ObjectMenuManager intscore;


    //...ObjectMenu..//
    private float swipeSum;
    private float touchLast;
    private float touchCurrent;
    private float distance;
    private bool hasSwipedLeft;
    private bool hasSwipedRight;
    public ObjectMenuManager objectMenuManager;
    //public Text Active;

    //GarbageStick//
    public float speed = 5f;
    public bool shouldmove = true;

    public GameObject leftclaw;
    public GameObject rightclaw;

    public Collider leftClaw;
    public Collider rightClaw;
    public List<Rigidbody> Rubish;

    //...Put in inventroy....//

    public GameObject Bocanci;
    public bool bocanciactivi = false;
    public GameObject puivultur;
    public bool puivulturactiv = false;
    public bool StickO1;
    public GameObject StickO;
    public GameObject Viveteleport;
    

    //------------------------------------------------------------------------------------------------------

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

    }
    void Start()
    {
        Viveteleport.GetComponent<TeleportVive>().enabled = false;
        Littertickbutton.GetComponent<AudioSource>();
        ClimbingButton.GetComponent<AudioSource>();
    }




    void Update()
    {
        StartCoroutine("Example2");


        
        device = SteamVR_Controller.Input((int)trackedObj.index);
        ObjectMenu();
        if (!isStick())
        {


            teleportActive.isleft = true;
            teleportActive.isright = true;
        }

        if (isStick())
        {

            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
            {


                ShouldmoveBack();
                leftClaw.enabled = true;
                rightClaw.enabled = true;
                panelIsNot.SetActive(false);
                foreach (Rigidbody Rubish in Rubish)
                {

                    Rubish.isKinematic = true;
                    Rubish.useGravity = false;
                }

            }
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
            {
                Shouldmove();
                leftClaw.enabled = false;
                rightClaw.enabled = false;
                leftclaw.gameObject.gameObject.transform.DetachChildren();
                rightclaw.gameObject.gameObject.transform.DetachChildren();
                foreach (Rigidbody Rubish in Rubish)
                {

                    Rubish.isKinematic = false;
                    Rubish.useGravity = true;
                }
            }
            panelIsNot.SetActive(false);
            sStick.GetComponent<OntriggerEnterBootsEagle>().isstick = true;


        }
        if (isStick() == true&& !isNOtStick())
        {
            panelIsNot.SetActive(true);

        }

        if (isStick() == false)
        {
            panelIsNot.SetActive(false);
        }
    }



    public bool isStick()
    {

        return (sStick.transform.parent == gameObject.transform || sStick.transform.parent == leftController.gameObject.transform);
    }
    public bool isNOtStick()
    {

        return (sStick.transform.parent == gameObject.transform || sStick.transform.parent == rightController.gameObject.transform);

    }



    /* -------------------------------------------------------------------------------------------------------------------------------------------------------- //

                                                                                    Grabbing and Throwing
    // -------------------------------------------------------------------------------------------------------------------------------------------------------- */


    void GrabObject(Collider col)
    {
        col.transform.SetParent(gameObject.transform);
        col.GetComponent<Rigidbody>().isKinematic = true;
        device.TriggerHapticPulse(40);
        shouldmove = true;
    }

    void ThrowObject(Collider col)
    {
        col.transform.SetParent(null);
        Rigidbody rigidbody = col.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
        rigidbody.velocity = device.velocity * throwForce;
        rigidbody.angularVelocity = device.angularVelocity;
    }
    void Bin(Collider col)
    {

        col.transform.SetParent(null);
        Rigidbody rigidbody = col.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
       



    }
    void Usa(Collider col)
    {
        Rigidbody rigidbody = col.GetComponent<Rigidbody>();
        col.transform.SetParent(gameObject.transform);
        col.GetComponent<Rigidbody>().isKinematic = true;
        device.TriggerHapticPulse(40);
        shouldmove = true;
        rigidbody.velocity = device.velocity * throwForce;
        rigidbody.angularVelocity = device.angularVelocity;



    }

    public void ClimbingBoots()
    {
        
        boots.SetActive(true);
    }
    public void LitterStick()
    {
        
        LitterStic.SetActive(true);
        RewardhasbeenclaimedLitter.text = "Reward has been claimed";
    }
    public void Shouldmove()
    {
        if (shouldmove)
        {
            
            leftclaw.transform.localPosition = new Vector3(-0.046f, -1.995f, 0.47f);
            rightclaw.transform.localPosition = new Vector3(-0.046f, -1.995f, 0f);


        }


    }
    void ShouldmoveBack()
    {
        if (shouldmove)
        {
            
            leftclaw.transform.localPosition = new Vector3(0.03639535f, -1.994164f, 0.2363327f);
            rightclaw.transform.localPosition = new Vector3(0.03739594f, -1.988162f, 0.2593345f);

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Button") && gameManager.score >= Reward)
        {
            Climbing.material = Enterreward;
           }
        if (other.gameObject.CompareTag("Button1") && gameManager.score >= Reward1)
        {                       
                Litter1.material = Enterreward; 
                                    
        }
        if (other.gameObject.CompareTag("Buttonchose right"))
        {
           
            {
                paneldecizRightOnentry.material = DecizionRight;
            }

        }
        if (other.gameObject.CompareTag("ButtonChoseLeft"))
        {
            
            {
                paneldecizLeftOnentry.material = DecizionLeft;
            }

        }
        if (other.gameObject.CompareTag("Ground"))
        {

            {
                other.transform.DetachChildren();
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Rubish") || other.gameObject.CompareTag("Beer") || other.gameObject.CompareTag("Packet") || other.gameObject.CompareTag("BBQ") || other.gameObject.CompareTag("Stick") || other.gameObject.CompareTag("After"))
        {
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                ThrowObject(other);
                
                
            }
            else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                GrabObject(other);
                other.GetComponentInChildren<NUmberPlay>().enabled = true;
                other.GetComponentInChildren<GameObject>().SetActive(true);

            }
        }
        if (other.gameObject.CompareTag("Bin"))

        {
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Bin(other);
            }
            else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                GrabObject(other);
            }

        }
        if (other.gameObject.CompareTag("Usa"))

        {
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Bin(other);
            }
            else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                Usa(other);
            }

        }
        if (other.gameObject.CompareTag("Button") && gameManager.score >= Reward)
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                LitterStick();
                LitterSticdelivered.Play();
                
                StartCoroutine("Example");
                intscore.number[2] = intscore.number[2] + 1;
               


            }
        }
        if (other.gameObject.CompareTag("Button1") && gameManager.score >= Reward1)
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                

                ClimbingBoots();
                bootsdelivered.Play();
                RewardhasbeenclaimedBoots.text = "Reward has been claimed";
                StartCoroutine("Example1");
                
            }
        }
        if(other.gameObject.CompareTag("Buttonchose right"))
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                Application.Quit();
                Destroy(paneldecizLeftOnentry1);
                Destroy(paneldecizRightOnentry1);
                
            }

        }
        if (other.gameObject.CompareTag("ButtonChoseLeft"))
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {

                
                Destroy(paneldecizLeftOnentry1);
                paneldecizRightOnentry1.SetActive(false);
               
            }

        }
    }
         private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Button") && gameManager.score >= Reward)
        {
            Climbing.material = mat1;
        }
        if (other.gameObject.CompareTag("Button1") && gameManager.score >= Reward1)
        {
            Litter1.material = mat1;
        }
        if (other.gameObject.CompareTag("Buttonchose right"))
        {

            {
                paneldecizRightOnentry.material = DecizionExit;
                paneldecizLeftOnentry.material = DecizionExit;
               
            }

        }
        if (other.gameObject.CompareTag("ButtonChoseLeft"))
        {

            {
                paneldecizLeftOnentry.material = DecizionExit;
                paneldecizRightOnentry.material = DecizionExit;
               

            }

        }

    }





    IEnumerator Example()
    {

        yield return new WaitForSeconds(3f);
        Littertickbutton.GetComponent<AudioSource>().enabled = false;
        

    }
    IEnumerator Example1()
    {

        yield return new WaitForSeconds(3f);
        ClimbingButton.GetComponent<AudioSource>().enabled = false;

    }







    /* -------------------------------------------------------------------------------------------------------------------------------------------------------- //

                                                                                   Object Menu
   // -------------------------------------------------------------------------------------------------------------------------------------------------------- */

    void ObjectMenu()
    {

        {
            if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
            {
                touchLast = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad).x;
            }
            if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
            {
                touchCurrent = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad).x;
                distance = touchCurrent - touchLast;
                touchLast = touchCurrent;
                swipeSum += distance;

                if (!hasSwipedRight)
                {
                    if (swipeSum > 0.3f)
                    {
                        swipeSum = 0;
                        SwipeRight();
                        hasSwipedRight = true;
                        

                    }
                }

                if (!hasSwipedLeft)
                {
                    if (swipeSum < -0.3f)
                    {
                        swipeSum = 0;
                        SwipeLeft();
                        hasSwipedLeft = true;
                       

                    }
                }
            }

            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Touchpad))
            {

                int currentObject = objectMenuManager.currentObject;
                objectMenuManager.objectList[currentObject].SetActive(false);

                swipeSum = 0;
                touchCurrent = 0;
                touchLast = 0;
                hasSwipedLeft = false;
                hasSwipedRight = false;
            }

            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger) && device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
            {
                SpawnObject();


            }

        }
    }

    void SwipeRight()
    {
        objectMenuManager.MenuRight();
    }

    void SwipeLeft()
    {
        objectMenuManager.MenuLeft();
    }

    void SpawnObject()
    {
        objectMenuManager.SpwanCurrentObject();
    }
    IEnumerator Example2()
    {

        yield return new WaitForSeconds(20f);
        Viveteleport.GetComponent<TeleportVive>().enabled = true;
        paneldecizLeftOnentry1.SetActive(true);
        paneldecizRightOnentry1.SetActive(true);



    }
    IEnumerator Example3()
    {

        yield return new WaitForSeconds(6f);
       // Mybackplay.enabled = false;


    }
}


    

