using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InstructionManager : MonoBehaviour {

	private SteamVR_TrackedObject trackedObj;
	private SteamVR_Controller.Device device;
	public GameObject canvas;
    public GameObject canvasmenu;
	public Instructuction instruction;
	public Text tutorialText;
    public Text canvasText;
	public GameObject controllerText;
	public bool LeftController;
	public bool RightController;
    public bool Trigger;
    public bool Touchpad;
    public bool Grip;

	void Awake ()
	{
		trackedObj = GetComponentInParent<SteamVR_TrackedObject>();
	}

	void Update ()
	{
		device = SteamVR_Controller.Input((int)trackedObj.index);
		DisplayHints();
	}

	void DisplayHints ()
	{
		
		{
			if (LeftController)
			{
                //- loads the teleportation hint when user touches the touchpad
                if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
                {
                    tutorialText.text = "For climbing\nuse the grip \non the controllers\nPress the Grip"; //"Press the touchpad to begin\nthe instruction";
                    Trigger= true;
                }
                if (Trigger == true)
                {
                    if (device.GetPress(SteamVR_Controller.ButtonMask.Grip))
                    {
                        tutorialText.text = "For the\nlitter picker \nuse the right hand\nand  the up direction \non the touchpad\nPress Touchpad";
                        Grip = true;
                    }
                }
                    
                    if (Grip == true)
                    {
                        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
                          
                        {                                                    
                            tutorialText.text = "To interact with objects\nuse one of the\ncontroller and hold the trigger";
                        canvasText.text = "To win points you need to put the rubish in bins\nTo win the game you must SAVE THE FOREST by collecting all the litter\nleft by people in the forest";
                        Touchpad = true;
                        }
                    
                    }
                if (Touchpad == true)
                {
                    tutorialText.text = "To use an item from your\ninventory swipe left or right on the\ntouchpad and press the trigger ";
                }
                            										
				
				if (Grip==true&&Trigger==true&&Touchpad==true)
				{
                    instruction.LeftControllerTutorialCompleted = true;
                    canvasmenu.SetActive(true);
                }
			}
			if (RightController)
			{
				//- can only complete right controller tutorial if player has completed left controller tutorial
				if (instruction.LeftControllerTutorialCompleted == true)
				{
                    canvasmenu.SetActive(true);
                    if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
					{
						tutorialText.text = "To put an item\nin your inventory\n hold the object\nwith your controller and\nbring it close to your eyes\n Press trigger";
					}
					if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
					{
						instruction.RightControllerTutorialCompleted = true;
					}
				}
			}
			if (instruction.LeftControllerTutorialCompleted == true && instruction.RightControllerTutorialCompleted == true)
			{
				if (LeftController)
					controllerText.SetActive(false);
				if (RightController)
					controllerText.SetActive(false);
				canvas.SetActive (false);
                canvasmenu.SetActive(false);
			}
		}
	}
}
