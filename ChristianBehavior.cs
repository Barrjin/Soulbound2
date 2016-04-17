using UnityEngine;
using System.Collections;

public class ChristianBehavior : MonoBehaviour {

    public KitBehavior Kit;

    const float speed = 5;
    const float range = 3;

	// Use this for initialization
	void Start () 
    {
        gameObject.SetActive(false);
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
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-1.0f * speed, 0.0f));
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Kit.transform.position.x + range > transform.position.x)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0.0f));
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Kit.transform.position.y + range > transform.position.y)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, speed));
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Kit.transform.position.y - range < transform.position.y)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, -1.0f * speed));
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }

        if (Kit.transform.position.x + range < transform.position.x)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = new Vector2((Kit.transform.position.x + range), transform.position.y);
        }
        if (Kit.transform.position.x - range > transform.position.x)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = new Vector2((Kit.transform.position.x - range), transform.position.y);
        }
        if (Kit.transform.position.y + range < transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = new Vector2(transform.position.x, (Kit.transform.position.y + range));
        }
        if (Kit.transform.position.y - range > transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = new Vector2(transform.position.x, (Kit.transform.position.y - range));
        }
    }

    public void sleep()
    {
        transform.position = Kit.gameObject.transform.position;
        gameObject.SetActive(false);
    }

    public void wake()
    {
        transform.position = Kit.gameObject.transform.position;
        gameObject.SetActive(true);
    }
}
