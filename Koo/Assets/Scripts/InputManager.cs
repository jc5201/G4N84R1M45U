using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    private float horiz, enter;


    // Use this for initialization
    void Start () {
        horiz = 0;enter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (horiz != Input.GetAxis("Horizontal"))
        {
            horiz = Input.GetAxis("Horizontal");
            if (horiz != 0)
            {
                if (horiz == 1.0f) GameObject.Find("Cover").GetComponent<DoorControl>().moveRight();
            }
        }

        if (enter != Input.GetAxis("Enter"))
        {
            enter = Input.GetAxis("Enter");
            if (enter != 0)
            {
                if (enter == 1.0f) GameObject.Find("Main Camera").GetComponent<CamControl>().ZoomIn();
            }
        }
        
    }
}
