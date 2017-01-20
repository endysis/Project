using UnityEngine;
using System.Collections;

public class WeaponSwitching : MonoBehaviour {


	public int currentWeapon = 0;
	public int maxWeapons = 3;

	private Animator anim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			currentWeapon = 0;
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			currentWeapon = 1;
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			currentWeapon = 2;
		}

	}
}
