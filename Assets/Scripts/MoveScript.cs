using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	//Variables

	public Vector2 speed =  new Vector2(10,10); // Objects Velocity 

	public Vector2 direction = new Vector2(-1,0); // The object direction, always going to left

	public Vector2 movement; // Variable answerable of the object movement

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Movement

		movement = new Vector2 (speed.x * direction.x, speed.y * direction.y); // Set the movement 
	}

	void FixedUpdate () {
		rigidbody2D.velocity = movement; // Apply movement to the object
	}
}
