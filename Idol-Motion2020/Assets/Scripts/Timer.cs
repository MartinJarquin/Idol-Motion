using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    // Variable for scaling the Timer 
    // initialTimerSize is to be set on Start()
    // finalTimerSize is to be set by pulling one of the hit boxes and taking that local scale
    private Vector3 initialTimerSize = new Vector3(.35f, .35f, .35f);
    private Vector3 finalTimerSize;
    //FIX THIS 
    private Vector3 timerSize = new Vector3(0, 0, 0);
    private float timeToShrink;
    private float timeTracker;
    public BeatManager BM;
    public ActivateBoxes AB;
    float Duration;
    float endTime;
    float curTime;

   

    void Start()
    {
        // duration is our 3 crotchet 
        // we actually need to create at least 3 timers I think. 
        // and they wont move to a new ball until the 3 beats are up. right now the same timer is being moved every beat in activate boxes, but we need to 
        // onnly move the box that just finihsed its duration
    }


    private void OnEnable()
    {
        Duration = BM.crotchet / 3.0f;
        endTime = Time.time + Duration;

        finalTimerSize = AB.hitBox1.transform.GetChild(0).localScale;
        // initialTimerSize = this.transform.localScale;
    }

    void Update()
    {
        curTime = Time.time;
        //endtime - currenttime
        timerSize = Vector3.Lerp(finalTimerSize, initialTimerSize, Mathf.Clamp01((endTime - curTime) / Duration));

        this.transform.localScale = timerSize;

        //3 times beat has elapsed
        if (curTime > endTime)
        {
            //should deactivate
            gameObject.SetActive(false);
        }

    }


/// if the lerp formula is (1-t)a + (t)b then as t progress we get further form a and closest to b
///  we are incrementing that time each frame, but lerping by a third of that time because we want the shrink to start 3 beats in advance 
///  that time duration that we want it to lerp over is the crotchet / 3
///  so for each ball, as soon as its set to active we begin to shrink it. we set the start time to zero. and then shrink it over the 


}
