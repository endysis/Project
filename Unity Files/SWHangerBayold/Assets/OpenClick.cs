using UnityEngine;
using System.Collections;

public class OpenClick : MonoBehaviour {



	bool onOff = false;

	public GameObject door;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	 public void onClick(){
		if (onOff == false) {
			onOff = true;
		} else {
			onOff = false;
		}
	}

}



