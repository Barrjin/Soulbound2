using UnityEngine;
using System.Collections;

public class BehaviorScript : MonoBehaviour {

    bool active = false;

    public Collider2D Kit;
	// Use this for initialization
	void Start () 
    {
        GetComponent<SpriteRenderer>().enabled = false;
	}

    public void Awaken()
    {
        active = true;
        transform.position = new Vector2(0, 0);
        GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Inside SpiritScript");
    }

    public void Asleep()
    {
        active = false;
        transform.position = new Vector2(0, 0);
        GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (active)
        {
            
        }
	}
}
