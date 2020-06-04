using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBoxes : MonoBehaviour
{

    /// <summary>
    ///  responsible for reading in the spawn placements based on the read file
    ///  uses activate or deactivate class on the balls when they're supposed
    ///  then it uses the timer class based on the spawning ball to tell the player how long
    ///  they have to hit it before it moves
    /// </summary>

    public float hbCrotchet = 0;
    public GameObject activeHitbox;
    public GameObject activeHitbox2;
    Vector3 target = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 resetScale = new Vector3(0.2f, 0.2f, 0.2f);

    // the large balls that close in on the players current target each beat
    public GameObject leftTimer;
    public GameObject rightTimer;

    // object pooling
    public GameObject hitBox1, hitBox2, hitBox3, hitBox4, hitBox5, hitBox6, hitBox7, hitBox8, hitBox9,
        hitBox10, hitBox11, hitBox12, hitBox13, hitBox14, hitBox15, hitBox16;

    void Start()
    {
        activeHitbox = hitBox1;
        activeHitbox2 = hitBox1;
        
        // InvokeRepeating("moveBoxes", 0f, 1f);
    }

    // other is the light stick
    void OnCollisionEnter(Collision other)
    {
        //feels and feedback stuff
        if ((other.gameObject.tag.Equals("GameController")) && (this.gameObject.tag.Equals("hitBox")))
        {

            activeHitbox = this.gameObject;
            activeHitbox2 = this.gameObject;

            //show them they hit it
            activeHitbox.GetComponent<MeshRenderer>().material.color = Color.black;
            activeHitbox2.GetComponent<MeshRenderer>().material.color = Color.black;

            //so martin is calling this script from beat manager to move the boxes
            //collision is in here to reset the color as soon as its been hit and log things. 
            // I just need to log them to write them to a script but 
            //should just make a new file called hit managaer that calls the create file one

        }

    }


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


    }
    private void normalNotes(string leftColor, string rightColor, string Lhit, string Rhit)
    {
        activeHitbox.SetActive(false);
        activeHitbox2.SetActive(false);
        //leftTimer.transform.localScale = resetScale;
        //rightTimer.transform.localScale = resetScale;
        
        switch (Lhit)
        {
            case "01":
                activeHitbox = hitBox1;
                leftTimer.transform.position = hitBox1.transform.localPosition;
                leftTimer.transform.localRotation = hitBox1.transform.localRotation;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "02":
                activeHitbox = hitBox2;
                leftTimer.transform.localPosition = hitBox2.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "03":
                activeHitbox = hitBox3;
                leftTimer.transform.localPosition = hitBox3.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "04":
                activeHitbox = hitBox4;
                leftTimer.transform.localPosition = hitBox4.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "05":
                activeHitbox = hitBox5;
                leftTimer.transform.localPosition = hitBox5.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "06":
                activeHitbox = hitBox6;
                leftTimer.transform.localPosition = hitBox6.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;
                
            case "07":
                activeHitbox = hitBox7;
                leftTimer.transform.localPosition = hitBox7.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            case "08":
                activeHitbox = hitBox8;
                leftTimer.transform.localPosition = hitBox8.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, leftTimer);
                break;

            default:
                break;
        }

        switch (Rhit)
        {
            case "09":
                activeHitbox2 = hitBox9;
                rightTimer.transform.localPosition = hitBox9.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "10":
                activeHitbox2 = hitBox10;
                rightTimer.transform.localPosition = hitBox10.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "11":
                activeHitbox2 = hitBox11;
                rightTimer.transform.localPosition = hitBox11.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "12":
                activeHitbox2 = hitBox12;
                rightTimer.transform.localPosition = hitBox12.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "13":
                activeHitbox2 = hitBox13;
                rightTimer.transform.localPosition = hitBox13.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "14":
                activeHitbox2 = hitBox14;
                rightTimer.transform.localPosition = hitBox14.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            case "15":
                activeHitbox2 = hitBox15;
                rightTimer.transform.localPosition = hitBox15.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);                
                break;

            case "16":
                activeHitbox2 = hitBox16;
                rightTimer.transform.localPosition = hitBox16.transform.localPosition;
                ScaleToTarget(target, hbCrotchet, rightTimer);
                break;

            default:
                break;
        }
        activeHitbox.SetActive(true);
        activeHitbox2.SetActive(true);
        //new WaitForSeconds(1f);
        //reset(activeHitbox);
        //reset(activeHitbox2);
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

    IEnumerator reset(GameObject activeHitboxx)
    {
        yield return new WaitForSeconds((hbCrotchet * 4));
        if (activeHitboxx.activeSelf == true)
        {
            activeHitboxx.SetActive(false);

        }
    }

    private void FixedUpdate()
    {
        //every five seconds?? needs to adhere to each songs bpm, gotta recalculate

        //will want to use for changing hit boxes because more accurate and reliable


        //  Debug.Log("THEEEEEEEEEEE CAMERA HEIGHT IS" + oculus.transform.position);
        //  Debug.Log("HITBOX HEIGHT IS" + hitbox.transform.position);

    }

    public void sendCrotchet(float crot)
    {
        hbCrotchet = crot;
    }

    public void ScaleToTarget(Vector3 targetScale, float duration, GameObject hb)
    {
        leftTimer.SetActive(true);
        rightTimer.SetActive(true);
        //StartCoroutine(ScaleToTargetCoroutine(targetScale, duration, hb));
    }

    private IEnumerator ScaleToTargetCoroutine(Vector3 targetScale, float duration, GameObject hb)
    {
        Vector3 startScale = hb.transform.localScale;
        float timer = 0.0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float t = timer / duration;
            //smoother step algorithm
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            hb.transform.localScale = Vector3.Lerp(startScale, targetScale, t);
            yield return null;
        }

        yield return null;
    }
}
