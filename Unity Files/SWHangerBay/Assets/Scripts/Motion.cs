using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour {


    public GameObject camera;
    public GameObject model;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


   void OnTriggerEnter(){
        camera.transform.parent = model.transform;
    }



}









