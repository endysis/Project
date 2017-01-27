using UnityEngine;
using System.Collections;

public class ColliderRotate : MonoBehaviour {

	public GameObject world;
    public GameObject objectPoint;
    public GameObject attentionObject;
    public GameObject[] distractObject;

   // public AudioSource attentionAudio;
   // public AudioSource distractAudio;

    public bool left = false;
	public bool right = false;
	public float rotationAmount;
	public float rotationSpeed;
    public float timer = 4.0f;
    private bool timerOn = false;
    private Animator animAt;
    private Animator[] animDis;
    private int collideCount = 0; // So the animation only can play once.


	// Use this for initialization
	void Start () {
        animAt = attentionObject.GetComponent<Animator>();
        animDis = new Animator[distractObject.Length];
       
        for (int i = 0; i < distractObject.Length; i++) {
            animDis[i] = distractObject[i].GetComponent<Animator>();
        }
 
    
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
        //Debug.Log(distractObject.Length);
        Debug.Log(animDis.Length);

        if (collideCount <= 0) // So sequences only play if collided with once.
        {
            // So Start Attention Sequence.
            animAt.SetBool("posCheck", true);
            //attentionAudio.Play();

            timerOn = true;
            collideCount++;
        }

        else {
            // Do nothing
        }
    }



    void rotateWorld() {

        // Play the distract animation at this point
        //distractAudio.Play();

        for (int i = 0; i < animDis.Length; i++) {
            animDis[i].SetBool("posCheck",true);
        }

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






















