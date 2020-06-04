using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class GameManager : MonoBehaviour
    {
        public AudioPlayer ap;
        public BeatManager conductor;
        float dsptimesong = 0;

        // Use this for initialization
        void Start()
        {

            //passes meta data to the BeatManager
            conductor.getSong(ap.selectedSong);

            //plays the song
            ap.selectedSong.songFile.Play();

            //gets the time the song started playing
            dsptimesong = (float)AudioSettings.dspTime;
            conductor.setdsptimesong(dsptimesong);
        }

        // Update is called once per frame
        void Update()
        {


        }
    }
}
