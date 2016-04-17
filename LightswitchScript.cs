using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightswitchScript : MonoBehaviour 
{
    public List<GameObject> lights;
    public bool isOn = true;

	void Start () 
    {
        
	}
	
	void Update () 
    {
	
	}

    public void flip()
    {
        isOn = !isOn;

        if (isOn)
        {
            Debug.Log("Light is now on");
        }
        else
        {
            Debug.Log("Light is now off");
        }
    }

}
