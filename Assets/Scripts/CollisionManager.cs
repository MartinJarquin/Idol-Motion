using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {

    public static CollisionManager singleton; 
	// Use this for initialization
	void Start () {
		if(singleton && singleton != this)
        {
            Destroy(this);
        }
        else
        {
            singleton = this;
        }
	}

    //public void TriggerVibration(AudioClip vibAudio, OVRInput.Controller controller)
    //{

    //    OVRHapticsClip clip = new OVRHapticsClip(vibAudio);

    //    if(controller == OVRInput.Controller.LTouch)
    //    {
    //        OVRHaptics.LeftChannel.Preempt(clip);
    //    }
    //    else if (controller == OVRInput.Controller.RTouch)
    //    {
    //        OVRHaptics.RightChannel.Preempt(clip);
    //    }

    //}
}
