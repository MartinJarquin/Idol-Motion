using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class hitSound : MonoBehaviour
    {

        public AudioClip bloopSound;
        // Use this for initialization
        void Start()
        {

        }

        //other being passed in is YOUR LIGHTSTICK
        //"this" is what we hit
        void OnCollisionEnter(Collision other)
        {

            //feels and feedback stuff
            //if (this.gameObject.name.Equals("lightStickLeft"))
            //{
            //    vibrationManager.singleton.TriggerVibration(bloopSound, OVRInput.Controller.LTouch);
            //}
            //else if (this.gameObject.name.Equals("lightStickRight"))
            //{
            //    vibrationManager.singleton.TriggerVibration(bloopSound, OVRInput.Controller.RTouch);
            //}

            //GetComponent<AudioSource>().PlayOneShot(bloopSound);

        }

        // Update is called once per frame
        void Update()
        {

        }




    }
}
