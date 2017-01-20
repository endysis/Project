using UnityEngine;
using System.Collections;

public class animationChange : MonoBehaviour {

	private GameObject player;

	private GameObject weapon;

	private WeaponSwitching weaponSelected;

	private Animator anim;

	// Use this for initialization
	void Start () {

		weapon = GameObject.Find("Melee");
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		weaponSelected = weapon.gameObject.GetComponent<WeaponSwitching>();

		if (weaponSelected.currentWeapon == 0) {
			anim.SetBool("weaponArmed",false);

		} else {
			anim.SetBool("weaponArmed",true);
		}

	}
}
