using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    Vector3 pos;

    public void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        

        if (Input.GetKey("a"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
