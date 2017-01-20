
﻿using UnityEngine;
using System.Collections;

public class WandController : MonoBehaviour {
	
	private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
	public bool gripButtonDown = false;
	public bool gripButtonUp = false;
	public bool gripButtonPressed = false;
	
	
	
	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_Grip;
	public bool triggerButtonDown = false;
	public bool triggerButtonUp = false;
	public bool triggerButtonPressed = false;
	
	
	

	
	
	
	private SteamVR_TrackedObject trackedObj;
	private SteamVR_Controller.Device controller {
		get {
			return SteamVR_Controller.Input((int) trackedObj.index);
		}
	}
	
	
	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (controller == null) {
			Debug.Log("Controller not installed");
			return;
		}
		
		
		gripButtonDown = controller.GetPressDown(gripButton);
		gripButtonUp = controller.GetPressUp(gripButton);
		gripButtonPressed = controller.GetPressUp(gripButton);
		
		triggerButtonDown = controller.GetPressDown(triggerButton);
		triggerButtonUp = controller.GetPressDown(triggerButton);
		triggerButtonPressed = controller.GetPressDown(triggerButton);
		
		if (gripButtonDown) {
			Debug.Log("Grip Button Pressed");
		}
		if (gripButtonUp) {
			Debug.Log("Grip BUtton Unpressed");
		}
		if (triggerButtonDown)
		{
			Debug.Log("Trigger Button Pressed");
		}
		if (triggerButtonUp)
		{
			Debug.Log("Trigger Button Unpressed");
		}
		
	}
}