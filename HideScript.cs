using UnityEngine;
using System.Collections;

public class HideScript : MonoBehaviour 
{
    public KitBehavior Kit;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    public void hide()
    {
        if (!Kit.getSpirit())
        {
            Kit.changeHidden();

            if (Kit.getHidden())
            {
                Debug.Log("Kit is hidden");
            }
            else if (!Kit.getHidden())
            {
                Debug.Log("Kit is not hidden");
            }
                
        }

    }
}
