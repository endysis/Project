using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour {

	public GameObject player;
	public float speed = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Q)){
			player.transform.Rotate(Vector3.up * speed * Time.deltaTime);
			Debug.Log("Q KEY PRESSED");
		}

		if (Input.GetKey(KeyCode.E)){
			player.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
			Debug.Log("E KEY PRESSED");
		}
	}
}




