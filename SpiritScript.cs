using UnityEngine;
using System.Collections;

public class SpiritScript : MonoBehaviour 
{
    public BehaviorScript ChristianBehavior;
	public GameObject Christian;
    public Rigidbody2D rb;


    public bool spirit = false;
    bool faceRight = true;


    public const float maxSpeed = 100;
    public const float acceleration = 2;
    public const float spiritSpeed = 5;


    double currentSpeed = 0;

    private Vector2 mouseLocation;

	// Use this for initialization
	void Start () {

        rb = gameObject.GetComponent<Rigidbody2D>();
        //mouseLocation = transform.position;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
	}

	void processMovement()
	{
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (currentSpeed <= -1.0 * maxSpeed)
            {
                rb.AddForce(new Vector2((-1.0f * acceleration), 0));
                currentSpeed -= 1.0 * acceleration;
            }
            faceRight = false;
        }

	}

   /* void processChristianMovement()
    {
Debug.Log("Process Spirit Movement");

        mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseLocation.x = transform.position.x;

        Christian.transform.position = Vector2.MoveTowards(transform.position, mouseLocation, spiritSpeed * Time.deltaTime);
    }*/
	
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.LeftControl)) 
        {
            if (!spirit) 
            {
Debug.Log("Spirit made");
                spirit = true;

                ChristianBehavior.Awaken();
            } 

            else 
            {
Debug.Log("Spirit destroyed");
                spirit = false;

                ChristianBehavior.Asleep();
            }
        }
//Debug.Log(move);
    }

	// Update is called once per frame
	void FixedUpdate () 
    {
        if (!spirit)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                processMovement();
            }
        }
        else
        {
            if (Input.mousePresent)
            {
                //processChristianMovement();
            }
        }

        if (!faceRight)
        {
            //Debug.Log("Left");
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            //Debug.Log("Right");
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
		
		
}
