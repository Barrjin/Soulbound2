using UnityEngine;
using System.Collections;

public class LockedDoorScript : MonoBehaviour {

    public bool locked;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void changeLock()
    {
        locked = !locked;
        if (locked)
            gameObject.layer = 11;
        else if (!locked)
            gameObject.layer = 17;
    }
}
