using UnityEngine;
using System.Collections;

public class ColliderRotate : MonoBehaviour {

	public GameObject world;
    public GameObject objectPoint;
    public GameObject distractObject;
	public bool left = false;
	public bool right = false;
	public float rotationAmount;
	public float rotationSpeed;
    private Animator anim;


	// Use this for initialization
	void Start () {
        anim = distractObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Rotation Amount : " + world.transform.rotation.y);
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("Collided");
		if ((left == false && right == false) || (left == true && right == true)) {
			// Do nothing
			Debug.Log ("Impossible Input || No direction selected");
		} else if (left == true) {
			world.transform.RotateAround(objectPoint.transform.position,-world.transform.up * rotationAmount, Time.deltaTime * rotationSpeed);
		} else if(right == true) {
			world.transform.RotateAround(objectPoint.transform.position,world.transform.up * rotationAmount, Time.deltaTime * rotationSpeed);
		}  
	}
}






















