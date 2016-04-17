using UnityEngine;
using System.Collections;

public class ActionScript : MonoBehaviour 
{

    //private BoxCollider2D hitbox;
    private InteractableObject otherObject;

	void Start () 
    {
        //hitbox = gameObject.GetComponent<BoxCollider2D>();
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<InteractableObject>())
        {
            Debug.Log(col.gameObject.name);
            otherObject = col.gameObject.GetComponent<InteractableObject>();
        }
    }

    void OnTriggerExit2D()
    {
        otherObject = null;
        Debug.Log("No More Collision");
    }

	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (otherObject)
            {
                otherObject.Interact();
            }
        }
	}
}
