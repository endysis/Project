using UnityEngine;
using System.Collections;

public class closeProxCube : MonoBehaviour {

	public bool close;


	public GameObject menu;


	// Use this for initialization
	void Start () {
		menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		menu.SetActive(true);
	}

	void OnTriggerExit(Collider other){
		menu.SetActive (false);
	}






	public	bool getProx (){
		bool prox = close;
		return prox;
	}
	
}






