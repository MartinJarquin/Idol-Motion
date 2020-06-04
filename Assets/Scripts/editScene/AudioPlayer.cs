using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class AudioPlayer : MonoBehaviour
    {
        public SongObjects selectedSong;
        bool startPlaying = false;
        //float songPosition = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


        }



        public void playSong()
        {

            if (!startPlaying)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    startPlaying = true;

                    selectedSong.songFile.Play();

                }
            }
        }

    }
}
