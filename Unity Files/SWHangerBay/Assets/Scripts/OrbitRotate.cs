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


	// Use this for initialization
	void Start () {
        lastLoggedRotPosition = objectPlayerPosition.transform.rotation.y;
        currRotPosition = lastLoggedRotPosition;
	}
	
	// Update is called once per frame
	void Update () {
		currRotPosition = objectPlayerPosition.transform.rotation.y;    
		Debug.Log("Current Rot Y position" + currRotPosition);

		if(currRotPosition != lastLoggedRotPosition){
			rotationChange = (lastLoggedRotPosition - currRotPosition);
			Debug.Log("Position Changed by : " + rotationChange);
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
