using UnityEngine;
using System.Collections;

public class AppearMenu : MonoBehaviour {


	public GameObject doorMenu;
	private bool isShowing;




	public GameObject otherGameObject;
	public bool check;


	private closeProxCube cPC;




	// Use this for initialization

	void Awake () 
	{
		cPC = otherGameObject.GetComponent<closeProxCube>();
	}


	void Start () {
		//otherGameObject = GameObject.Find ("ConsoleC");
		isShowing = false;
		doorMenu.SetActive(isShowing);
		} 



	// Update is called once per frame
	void Update () {
		otherGameObject = GameObject.Find ("ConsoleC");
		cPC = otherGameObject.GetComponent<closeProxCube> ();

		if (cPC.close == true) {
			isShowing = true;
			check = true;
			doorMenu.SetActive(isShowing);
		} else {
			isShowing = false;
			check = false;
			doorMenu.SetActive(isShowing);
		}
	}




}
