using UnityEngine;
using System.Collections;

using Kino;

public class CamControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //gameObject.GetComponent<Bokeh>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ZoomIn()
    {
        gameObject.transform.Translate(new Vector3(0, 0, 5));
        //gameObject.GetComponent<Camera>().fieldOfView -= 20;
        //gameObject.GetComponent<Bokeh>().enabled = true;
    }
}
