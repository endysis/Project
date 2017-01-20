using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private GameObject player;

	public bool doorToggle;
	public bool closeCheck;

	private Animator anim;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator> ();
	//	anim.SetBool ("doorTogle", false);
	}

	/*public void changeOpenCheck (){
		if (openCheck == false) {
			anim.SetBool ("openCheck", true);
			anim.SetBool ("closeCheck", false);
			openCheck = true;
		} else if(openCheck == true){
			anim.SetBool ("openCheck", false);
			openCheck = false;
		}
	
	}

	public void changeCloseCheck () {
		if (closeCheck == false) {
			anim.SetBool ("closeCheck", true);
			anim.SetBool ("openCheck", false);
			closeCheck = true;
		} else if(closeCheck == true){
			anim.SetBool ("closeCheck", false);
			closeCheck = false;
		}
	}*/
	

public void toggleDoorOpen() {
			anim.SetBool ("doorToggle", true);
		}



public void toggleDoorClose() {
		anim.SetBool ("doorToggle", false);
	}



}




	
/*	public class Engine : MonoBehaviour {
		
		public bool Near;
		
		private Animator anim; // The animator component
		
		private GameObject player;
		
		// Use this for initialization
		void Start () {
			
		}
		
		
		// Update is called once per frame
		void Update () {
			anim = GetComponent<Animator> ();	
		}
		
		void OnTriggerEnter(Collider other){
			anim.SetBool ("Near", true);
		}
		
		void OnTriggerExit(Collider other){
			anim.SetBool ("Near",false);
		}
		
	}*/

