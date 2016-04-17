using UnityEngine;
using System.Collections;

public class InteractableObject : MonoBehaviour 
{

	void Start () 
    {
	
	}
	
	void Update () 
    {
	
	}

    public void Interact()
    {
        if (gameObject.name.Contains("Lightswitch"))
        {
            gameObject.GetComponent<LightswitchScript>().flip();
        }

        if (gameObject.name.Contains("Hide"))
        {
            gameObject.GetComponent<HideScript>().hide();
        }

        if (gameObject.name.Contains("OverheadLight"))
        {
            gameObject.GetComponent<OverheadlightBehavior>().unscrew();
        }

        if (gameObject.name.Contains("Lock") && gameObject.transform.parent)
        {
            gameObject.GetComponent<LockScript>().changeLock();
        }
    }
}