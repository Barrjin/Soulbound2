using UnityEngine;
using System.Collections;

public class OverheadlightBehavior : MonoBehaviour 
{
    public bool isScrewed = true;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }

    /*void OnCollisionEnter(Collision2D col)
    {
        if (col.gameObject.name == "Light1")
        {
            GetComponent<Animator>().speed = 1;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f * speed, 0);
        }
    }
   */
    public void unscrew()
    {
        isScrewed = !isScrewed;

        if (isScrewed)
            Debug.Log("Lightbulb screwed");
        else if (!isScrewed)
            Debug.Log("Lightbulb is unscrewed");
    }

}
