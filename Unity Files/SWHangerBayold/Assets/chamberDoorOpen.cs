using UnityEngine;
using System.Collections;

public class chamberDoorOpen : MonoBehaviour {


	public bool playerClose;


	private Animator anim;

	private GameObject player;


	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		anim.SetBool("playerClose",true);
		playerClose = true;
	}

	void OnTriggerExit(Collider other){
		anim.SetBool ("playerClose",false);
		playerClose = false;
	}

}
