using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditScene
{
    public class hitScreen : MonoBehaviour
    {

        //moves the entire play area based on the persons height
        public GameObject hitscreen;
        public Camera oculus;

        private void FixedUpdate()
        {
            hitscreen.transform.position = oculus.transform.position + new Vector3(.5f, -.25f, 1.5f);

        }
    }
}
