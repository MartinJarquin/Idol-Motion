using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class BeatNode : MonoBehaviour
    {
        string[,] topmiddlebottom = new string[4, 3];
        int quarterBeat = 0;
        int topMiddleBottom = 0;


        public BeatNode(string tmb)
        {
            //topmiddlebottom = tmb.Split(',');
        }
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
