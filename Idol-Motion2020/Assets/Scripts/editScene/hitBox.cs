using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;


namespace EditScene
{
    public class hitBox : MonoBehaviour 
    {

      //  public createFile fileClass;
     //   public object writer;
        //createFile fileClass = new createFile();
        //GameObject is a class, gameObject is a variable (which refers to the specific GameObject that the script is attached to).
        GameObject activeHitbox;
        GameObject activeHitbox2;

        public GameObject hitBox1, hitBox2, hitBox3, hitBox4, hitBox5, hitBox6, hitBox7, hitBox8, hitBox9, hitBox10, hitBox11, hitBox12, hitBox13, hitBox14, hitBox15, hitBox16, hitBox17, hitBox18;
        //better to just get transform? 
        public Camera oculus;
        int pos = 0;
        // Use this for initialization



        void Start()
        {


            //find references of hitboxes 1 - 16 because will have to eventually so just do once
            //deactivate them After otherwise wont be able to find instances
            //reactivate randomly within moveBoxes
            activeHitbox = hitBox1;
            activeHitbox2 = hitBox1;

        }

        //other being passed in is YOUR LIGHTSTICK
        //"this" is what we hit
        void OnCollisionEnter(Collision other)
        {
            //feels and feedback stuff
            Debug.Log("sent info");

            if ((other.gameObject.tag.Equals("GameController")) && (this.gameObject.tag.Equals("hitBox")))
            {

                activeHitbox = this.gameObject;
                activeHitbox2 = this.gameObject;
                // Debug.Log(activeHitbox);
                //gives hitBox2 (#)
                string name = activeHitbox.name;
                string name2 = activeHitbox2.name;
                Debug.Log("hi");

               // fileClass.sendInfo(name, name2);


                //show them they hit it
                // activeHitbox.GetComponent<MeshRenderer>().material.color = Color.black;
                // activeHitbox2.GetComponent<MeshRenderer>().material.color = Color.black;


            }

        }

        //read from beatmap file in beat manager
        public void moveBoxes(string sub)
        {
            //9 bits: 
            // non empty, wndsheild, ketcha, left hand color change, right hand color change, lefthand hitboxNumber, right hand hit box number
            //1 0100 01 18
            //1 0000 00 09
            //1 
            //non empty,4 "special moves" 
            //make sure the quarter note contains a hit box


            if (sub.StartsWith("1"))
            {
                return;
            }

            if (sub.StartsWith("0"))
            {
                //special moves String
                //string spcMov = sub.Substring(1, 2);

                //Color Changing string
                //string colorL = sub.Substring(3, 1);
                //string colorR = sub.Substring(4, 1);

                //Left hand hitbox, right hand hitbox
                //string leftHitbox = sub.Substring(5, 2);
                //string rightHitbox = sub.Substring(7, 2);

                checkSpecialMove(sub.Substring(1, 2));
                normalNotes(sub.Substring(3, 1), sub.Substring(4, 1), sub.Substring(5, 2), sub.Substring(7, 2));
            }

            activeHitbox.GetComponent<MeshRenderer>().material.color = Color.white;
            activeHitbox.SetActive(true);

            StartCoroutine(reset(activeHitbox));

            activeHitbox2.GetComponent<MeshRenderer>().material.color = Color.white;
            activeHitbox2.SetActive(true);

            StartCoroutine(reset(activeHitbox2));

        }
        private void normalNotes(string leftColor, string rightColor, string Lhit, string Rhit)
        {
            switch (Lhit)
            {
                case "01":
                    activeHitbox = hitBox1;
                    break;
                case "02":
                    activeHitbox = hitBox2;
                    break;
                case "03":
                    activeHitbox = hitBox3;
                    break;
                case "04":
                    activeHitbox = hitBox4;
                    break;
                case "05":
                    activeHitbox = hitBox5;
                    break;
                case "06":
                    activeHitbox = hitBox6;
                    break;
                case "07":
                    activeHitbox = hitBox7;
                    break;
                case "08":
                    activeHitbox = hitBox8;
                    break;
                case "09":
                    activeHitbox = hitBox9;
                    break;
                case "10":
                    activeHitbox = hitBox10;
                    break;
                case "11":
                    activeHitbox = hitBox11;
                    break;
                case "12":
                    activeHitbox = hitBox2;
                    break;
                case "13":
                    activeHitbox = hitBox13;
                    break;
                case "14":
                    activeHitbox = hitBox14;
                    break;
                case "15":
                    activeHitbox = hitBox15;
                    break;
                case "16":
                    activeHitbox = hitBox16;
                    break;
                case "17":
                    activeHitbox = hitBox17;
                    break;
                case "18":
                    activeHitbox = hitBox18;
                    break;
                default:
                    break;
            }

            switch (Rhit)
            {
                case "01":
                    activeHitbox2 = hitBox1;
                    break;
                case "02":
                    activeHitbox2 = hitBox2;
                    break;
                case "03":
                    activeHitbox2 = hitBox3;
                    break;
                case "04":
                    activeHitbox2 = hitBox4;
                    break;
                case "05":
                    activeHitbox2 = hitBox5;
                    break;
                case "06":
                    activeHitbox2 = hitBox6;
                    break;
                case "07":
                    activeHitbox2 = hitBox7;
                    break;
                case "08":
                    activeHitbox2 = hitBox8;
                    break;
                case "09":
                    activeHitbox2 = hitBox9;
                    break;
                case "10":
                    activeHitbox2 = hitBox10;
                    break;
                case "11":
                    activeHitbox2 = hitBox11;
                    break;
                case "12":
                    activeHitbox2 = hitBox2;
                    break;
                case "13":
                    activeHitbox2 = hitBox13;
                    break;
                case "14":
                    activeHitbox2 = hitBox14;
                    break;
                case "15":
                    activeHitbox2 = hitBox15;
                    break;
                case "16":
                    activeHitbox2 = hitBox16;
                    break;
                case "17":
                    activeHitbox2 = hitBox17;
                    break;
                case "18":
                    activeHitbox2 = hitBox18;
                    break;
                default:
                    break;
            }
        }

        private void checkSpecialMove(string specialMove)
        {
            switch (specialMove)
            {
                case "00":
                    break;

                case "01":
                    Debug.Log("Ketchup");
                    break;

                case "10":
                    Debug.Log("Wind shield");
                    break;
                default:
                    break;
            }
        }

        IEnumerator reset(GameObject activeHitbox)
        {
            yield return new WaitForSeconds(.8f);
            if (activeHitbox.activeSelf == true)
            {
                activeHitbox.SetActive(false);
            }

        }

    }
}
