using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotate : MonoBehaviour {

    public GameObject worldPosition;
    public GameObject objectPlayerPosition;
    private float lastLoggedRotPosition; // Last logged rotational position
    private float currRotPosition; // Current rotational position


	// Use this for initialization
	void Start () {
        lastLoggedRotPosition = objectPlayerPosition.transform.rotation.y;
        currRotPosition = lastLoggedRotPosition;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Current Rot Y position" + currRotPosition);
	}

    void rotateWorld() {

    }

}
