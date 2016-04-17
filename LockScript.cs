using UnityEngine;
using System.Collections;

public class LockScript : MonoBehaviour 
{
    public bool locked;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void changeLock()
    {
        locked = !locked;
        Debug.Log("Lock changed");
        gameObject.GetComponentInParent<LockedDoorScript>().changeLock();
    }
}
