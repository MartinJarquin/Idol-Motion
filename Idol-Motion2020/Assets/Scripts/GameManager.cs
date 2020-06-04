using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public AudioPlayer ap;
    public BeatManager conductor;
    float dsptimesong = 0;


    //this will be the status of the user
    public enum StateType
    {
        DEFAULT,      //Fall-back state, should never happen
        WAITING,      //waiting for other player to finish his turn
        STARTTURN,    //Once, on start of each player's turn
        PLAYING,      //My turn
        BUYING,       //Buying something new
        TURNOVER,
        GAMEOVER,
        GAMESTART,
        LOBBY,        //Player is in the lobby
        MENU,         //Player is viewing in-game menu
        OPTIONS       //player is adjusting game options
    };
    GameManager.StateType state;

    // Use this for initialization
    void OnEnable () {

        state = StateType.DEFAULT;
        //get song choice

        //passes meta data to the BeatManager
        conductor.getSong(ap.selectedSong);

        //plays the song
        ap.selectedSong.songFile.Play();

        //gets the time the song started playing
        dsptimesong = (float)AudioSettings.dspTime;
        conductor.setdsptimesong(dsptimesong);
    }
	
	// Update is called once per frame
	void Update () {
        switch (state)
        {
            case StateType.DEFAULT:
                break;
        }

	}
}
