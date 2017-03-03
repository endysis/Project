using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardUpdate : MonoBehaviour {

    public GameObject player;
    public GameObject world;
    public float scaleFactor = 0.02f;

    Vector3 lastLoggedPositionVec;
    Vector3 playerCurrentPositionVec;
    Vector3 positionDifference;

	// Use this for initialization
	void Start () {
        lastLoggedPositionVec = player.transform.position; // Set the position of the vectors
        playerCurrentPositionVec = player.transform.position;
    }

    // Update is called once per frame
    void Update () {
        playerCurrentPositionVec = player.transform.position; //Get the updated position of the camera
        posChangeCheck(); // Check to see if the player has moved.
	}


    void posChangeCheck() {
        if (playerCurrentPositionVec != lastLoggedPositionVec) // If there is a change in position
        {
            Debug.Log("Differece in player postion");
            positionDifference = lastLoggedPositionVec - playerCurrentPositionVec; // Find the difference between the lat know position of the player and the pos po they are in
            Debug.Log(positionDifference);
            updateWorld(); // Change the world in relation to the difference
            lastLoggedPositionVec = playerCurrentPositionVec; // Then log the position of the vector 
        }
        else {
            Debug.Log("No difference in player position");
            // Do nothing
        }
    }


    void updateWorld() {
        Vector3 newWorldPosition = world.transform.position;

        if (playerCurrentPositionVec.x != lastLoggedPositionVec.x) // Check again if the z position has changed, (if the player is moving forward)
        {
            newWorldPosition.x = newWorldPosition.x + (positionDifference.x * scaleFactor);   // Minus infront determines the position of the world
            world.transform.position = newWorldPosition;
        }
        else {
            // Do nothing
        }
    }   




}










































