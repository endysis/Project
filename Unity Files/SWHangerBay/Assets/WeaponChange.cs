using UnityEngine;
using System.Collections;

public class WeaponChange : MonoBehaviour {


	private GameObject l1;
	private GameObject l2;

	//public GameObject animation;

	private WeaponSwitching otherScript;


	public int weaponNumber;


	// Use this for initialization
	void Start () {
		l1 = GameObject.Find("L1");
		l2 = GameObject.Find ("L2");

		l1.SetActive(false);
		l2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {


	
		otherScript = GetComponent<WeaponSwitching>();
		weaponNumber = otherScript.currentWeapon;



		if (weaponNumber == 0) {
			l1.SetActive(false);
			l2.SetActive(false);
		}

		if (weaponNumber == 1) {
			l1.SetActive(true);
			l2.SetActive(false);
		}

		if (weaponNumber == 2) {
			l2.SetActive(true);
			l1.SetActive(false);
		}


	}
}
