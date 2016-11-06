using UnityEngine;
using System.Collections;

public class DoorControl : MonoBehaviour {

    public bool smoothMove;
    private float target, now = 0;

    private enum Status { move, stop}
    private Status status = Status.stop;

    private GameObject[] Contents = new GameObject[3];

	// Use this for initialization
	void Start () {
        Contents[0] = GameObject.Find("CenterContent");
        Contents[1] = GameObject.Find("RightContent");
        Contents[2] = GameObject.Find("LeftContent");
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(0,(target - now)/16 ,0));
        now += (target - now) / 16 ;
        if(target - now < 1)
        {
            status = Status.stop;
            foreach (GameObject obj in Contents) obj.SetActive(true);
        }
	}

    public void moveRight()
    {
        status = Status.move;
        foreach (GameObject obj in Contents) obj.SetActive(false);
        target += 60;
    }
}
