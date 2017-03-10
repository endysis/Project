using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotate : MonoBehaviour {

    public GameObject worldPosition;
    public GameObject objectPlayerPosition;
	public float scaleValue;
    private float lastLoggedRotPosition; // Last logged rotational position
    private float currRotPosition; // Current rotational position
	private float rotationChange;

    private float llPos = 0;
    private float cPos = 0; 


	// Use this for initialization
	void Start () {
        lastLoggedRotPosition = objectPlayerPosition.transform.eulerAngles.y;
        currRotPosition = lastLoggedRotPosition;
	}
	
	// Update is called once per frame
	void Update () {

        

        currRotPosition = (objectPlayerPosition.transform.eulerAngles.y - 90);    
		Debug.Log("Rot Y position" + currRotPosition);
        // Debug.Log("Last Logged Rot Y position" + lastLoggedRotPosition);
        Debug.Log("World Rot Y position " + worldPosition.transform.eulerAngles.y);

            if (currRotPosition != lastLoggedRotPosition)
            {
                rotationChange = (currRotPosition - lastLoggedRotPosition);
                //Debug.Log("Position Changed by : " + rotationChange);
                rotateWorld();
                lastLoggedRotPosition = currRotPosition;
            }
                 
	}
    
    void rotateWorld() {
	    worldPosition.transform.eulerAngles = new Vector3(
			worldPosition.transform.eulerAngles.x,
			worldPosition.transform.eulerAngles.y + -(rotationChange* scaleValue),
			worldPosition.transform.eulerAngles.z
		);
    }
}
