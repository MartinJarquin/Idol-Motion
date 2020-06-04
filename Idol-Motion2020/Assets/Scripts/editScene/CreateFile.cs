using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace EditScene
{
    public class CreateFile : MonoBehaviour
    {
        string path = "Assets/cardsFile.txt";
        StreamWriter writer;


        public void PrintName(string name)
        {
            Debug.Log("in the file creator");
            Debug.Log("TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT" + name);
        }

        public void sendInfo(string name, string name2)
        {
            Debug.Log("yo");
            writer = new StreamWriter(path, true);
            //mght need to use get down
            //should determine how to write the type of hit they did 



            //if (OVRInput.Get(OVRInput.Button.One))
            //{
            //    writer.WriteLine(name + " " + name2 + " " + "song pos" + AudioSettings.dspTime);
            //}
            //else if (OVRInput.Get(OVRInput.Button.Two))
            //{
            //    writer.WriteLine(name + " " + name2 + " " + "song pos" + AudioSettings.dspTime);

            //}
            //if ha(OVRInput.Get(OVRInput.Button.One)Touch 
            //send to function to write particular
            // else: normal 
            writer.WriteLine(name + " " + name2 + " " + "song pos" + AudioSettings.dspTime);

            writer.Close();
        }


        // bring home rift s
        /// my time
        ///  tuesday surgery and mon carpool and thing
        ///  tuesday becky
        ///  // gamestop!
        ///  // maybe shoukd think of a better driving situation? Unless wannt pay for parkin
        ///  also parking ticket
    }
}
