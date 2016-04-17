using UnityEngine;
using System.Collections;

public class followScript : MonoBehaviour {

    public Vector3 offset = new Vector3(0,0,-7);
    public GameObject Kit;
    public KitBehavior kitBehavior;
    public GameObject Christian;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (kitBehavior.getSpirit())
        {
            transform.position = Christian.transform.position + offset;
        }
        else
        {
            transform.position = Kit.transform.position + offset;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            
            Application.Quit();
        }
	}
}
