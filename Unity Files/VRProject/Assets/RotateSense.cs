using UnityEngine;
using System.Collections;

public class RotateSense : MonoBehaviour {

	public GameObject target;
	public GameObject person;
	public GameObject world;

	float fpsDistanceCurr;
	float fpsDistanceNew;

	// Use this for initialization
	void Start () {
		fpsDistanceCurr = Vector3.Distance(person.transform.position,transform.position);
		fpsDistanceNew = Vector3.Distance(person.transform.position,transform.position);
	}



	// Update is called once per frame
	void Update () {
		//Debug.Log(person.transform.position.x);
		Debug.Log("Distance : " + Vector3.Distance(person.transform.position,transform.position));
		fpsDistanceNew = Vector3.Distance(person.transform.position,target.transform.position); // Get the new distance between the capsule and the FPS
		if(fpsDistanceNew != fpsDistanceCurr){ // If the distance changes
			sense(fpsDistanceNew); // Call the sence fucntion which will alter the worlds roation accorindly.
		}
		 // Set the new Curr distance after the sense fucntion has completed.
	}


	void sense(float distance){
		float rotationLevel;
		float moveSpeed = 1f;

		if (distance < fpsDistanceCurr) { // If the distance is closer to the capsule
			rotationLevel = -(distance / 100); 
			Debug.Log("Rotation Level ; " + rotationLevel);
			world.transform.Rotate (Vector3.up * rotationLevel, moveSpeed);
		} else {
			rotationLevel = distance / 10; 
			world.transform.Rotate (Vector3.up * rotationLevel, moveSpeed);
		}	
		fpsDistanceCurr = fpsDistanceNew;
	}

}
