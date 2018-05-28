using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGripManager : MonoBehaviour {

    public Rigidbody Body;
    public Mpull left;
    public Mpull right;
    public GameObject player;
   
   
    
    void FixedUpdate()
    {
        var ldevice = SteamVR_Controller.Input((int)left.controller.index);
        var rdevice = SteamVR_Controller.Input((int)right.controller.index);
        bool isGripped = left.canGrip || right.canGrip;
        
        if (isGripped )
        {
            if (left.canGrip && ldevice.GetPress(SteamVR_Controller.ButtonMask.Grip ))

            {
                Body.useGravity = false;
                Body.isKinematic = true;
                Body.transform.position += (left.prevPos - left.transform.position);
               
            }
            else if (left.canGrip && ldevice.GetPressUp(SteamVR_Controller.ButtonMask.Grip))

            {

                Body.useGravity = true;
                Body.isKinematic = false;
                
               

            }

            if (right.canGrip && rdevice.GetPress(SteamVR_Controller.ButtonMask.Grip))

            {

                Body.useGravity = false;
                Body.isKinematic = true;
                Body.transform.position += (right.prevPos - right.transform.position);
                
            }
            else if (right.canGrip && rdevice.GetPressUp(SteamVR_Controller.ButtonMask.Grip))

            {
                Body.useGravity = true;
                Body.isKinematic = false;
                
             

            }


        }
        else
        {
            Body.useGravity = true;
            Body.isKinematic = false;
            
                      
        }

        
        
        left.prevPos = left.transform.position;
        right.prevPos = right.transform.position;
    }
    
}
