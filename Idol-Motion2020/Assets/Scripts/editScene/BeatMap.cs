using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class BeatMap : MonoBehaviour
    {
        public List<BeatNode> beatMapList = new List<BeatNode>();
        TextAsset textTmp;
        string tmpString = "";

        public BeatMap(TextAsset text)
        {
            generateBeatMap(text);
        }

        public void generateBeatMap(TextAsset t)
        {
            Debug.Log(textTmp);
        }
    }
}
