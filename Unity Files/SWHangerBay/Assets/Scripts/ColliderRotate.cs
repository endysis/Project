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
    float timer = 4.0f;
    public bool timerOn = false;
    private Animator anim;
    private int collideCount = 0; // So the animation only can play once.



	// Use this for initialization
	void Start () {
        anim = distractObject.GetComponent<Animator>();
	}
	

	// Update is called once per frame
	void Update () {

        if (timerOn) {
            timer -= Time.deltaTime;
        }

        if (timer <= 0) {
            timerOn = false;
            rotateWorld();
        }
        //Debug.Log("Rotation Amount : " + world.transform.rotation.y);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");


        anim.SetBool("posCheck",true);

        if (collideCount <= 0)
        {
            timerOn = true;
            collideCount++;
        }
        else {
            // Do nothing
        }
    }


    void rotateWorld() {
        if (collideCount == 1) { // So the world only rotates once.
            collideCount++;
            if ((left == false && right == false) || (left == true && right == true))
            {
                // Do nothing
                Debug.Log("Impossible Input || No direction selected");
            }
            else if (left == true)
            {
                world.transform.RotateAround(objectPoint.transform.position, -world.transform.up * rotationAmount, Time.deltaTime * rotationSpeed);
            }
            else if (right == true)
            {
                world.transform.RotateAround(objectPoint.transform.position, world.transform.up * rotationAmount, Time.deltaTime * rotationSpeed);
            }
        }
    }




}






















