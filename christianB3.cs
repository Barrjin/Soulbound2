using UnityEngine;
using System.Collections;

public class christianB3 : MonoBehaviour {

    public kitb3 Kit;

    public float speed = 5;
    public float range = 3.25f;

    // Use this for initialization
    void Start () 
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () 
    {

    }

    void FixedUpdate()
    {

    }

    //--------------------------------------------------------------------------------------------------------

    public void processMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Kit.transform.position.x - range < transform.position.x)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(-1.0f * speed, 0.0f));
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Kit.transform.position.x + range > transform.position.x)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0.0f));
            }
            else
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Kit.transform.position.y + range > transform.position.y)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, speed));
            }
            else
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Kit.transform.position.y - range < transform.position.y)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, -1.0f * speed));
            }
            else
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        if (Kit.transform.position.x + range < transform.position.x)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3((Kit.transform.position.x + range), transform.position.y);
        }
        if (Kit.transform.position.x - range > transform.position.x)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3((Kit.transform.position.x - range), transform.position.y);
        }
        if (Kit.transform.position.y + range < transform.position.y)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, (Kit.transform.position.y + range));
        }
        if (Kit.transform.position.y - range > transform.position.y)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, (Kit.transform.position.y - range));
        }
    }

    public void sleep()
    {
        transform.position = Kit.gameObject.transform.position;
        gameObject.SetActive(false);
    }

    public void wake()
    {
        //Debug.Log("Hello world");
        transform.position = Kit.gameObject.transform.position;
        gameObject.SetActive(true);
    }
}