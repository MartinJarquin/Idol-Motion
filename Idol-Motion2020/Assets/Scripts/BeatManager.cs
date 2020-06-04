using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



    public class BeatManager : MonoBehaviour
    {
        private SongObjects localSong;
        public ActivateBoxes dad;

        string beatMap = "";
        int left = 0;
        int right = 21;
        int counter = 0;

        public float crotchet;
        public float songPosition = 0;
        public float lastBeat;
        public float dsptimesong;
        public int i = 0;


        // Update is called once per frame
        void Update()
        {
            songPosition = (float)(AudioSettings.dspTime - dsptimesong) * localSong.songFile.pitch - localSong.offset;
            if (songPosition > lastBeat + crotchet)
            {
                //Debug.Log(localSong.map);

                lastBeat += crotchet;
                callBeatMap();
            }
        }

        public void getSong(SongObjects thisSong)
        {
            localSong = thisSong;
            lastBeat = 0;
            crotchet = 60 / localSong.bpm;
        }

        public void setdsptimesong(float time)
        {
            dsptimesong = time;
        }

        public void callBeatMap()
        {
            beatMap = localSong.map.ToString();

            if ((left + right) <= beatMap.Length)
            {
                dad.moveBoxes(beatMap.Substring(left, right));
                // Debug.Log("not null0" + left + " " );
            }
            else
            {
                left = 0;
                right = 21;
                counter++;
            }
            left += 22;
            // right += 22;
        }

    }
