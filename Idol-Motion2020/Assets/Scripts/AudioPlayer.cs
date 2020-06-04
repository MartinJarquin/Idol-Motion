using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {
    public SongObjects selectedSong;
    bool startPlaying = false;
    //float songPosition = 0;


    

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
