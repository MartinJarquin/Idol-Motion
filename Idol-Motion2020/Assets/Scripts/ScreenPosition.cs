
using UnityEngine;
using System.Collections;

public class ScreenPosition : MonoBehaviour
{

    public GameObject objectToFollow;

    //public float speed = 2.0f;
    public float x, y, z;

    void Update()
    {
        //float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        //Quaternion rotation = this.transform.rotation;

        position.y = objectToFollow.transform.position.y +y;
        position.x =objectToFollow.transform.position.x + x;
        position.z = objectToFollow.transform.position.z +z;

        //rotation.x = objectToFollow.transform.rotation.x;
        //rotation.y = objectToFollow.transform.rotation.y;
        //rotation.z = objectToFollow.transform.rotation.z;

        this.transform.position = position;
        //this.transform.rotation = rotation;
    }
}