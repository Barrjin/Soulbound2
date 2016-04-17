﻿using UnityEngine;
using System.Collections;

public class kitb3 : MonoBehaviour {

    public christianB3 Christian;

    const float speed = 3;

    bool spirit = false;

    // Use this for initialization
    void Start () 
    {

    }

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            if (spirit)
            {
                Debug.Log("SLEEP");
                Christian.sleep();
            }
            else if (!spirit)
            {
                Debug.Log("WAKE");
                Christian.wake();
            }
            spirit = !spirit;
        }
    }

    void FixedUpdate()
    {
        if (!spirit)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Animator>().speed = 1;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f * speed, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Animator>().speed = 1;

                transform.localRotation = Quaternion.Euler(0, 0, 0);
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Animator>().speed = 0;
                //GetComponent<Animator>().Stop();
            }
        }
        else if(spirit)
        {
            Christian.processMovement();
        }
    }

    public bool getSpirit()
    {
        return spirit;
    }
}
