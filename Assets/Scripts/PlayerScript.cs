using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	// Variables

	public Vector2 speed = new Vector2(50,50); // The speed of the ship

	public Vector2 movement; // The Movement of the ship

	private WeaponScript weapons;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		weapons = this.GetComponentInChildren<WeaponScript>();
	}
	
	// Update is called once per frame
	void Update () {
		float inputx = Input.GetAxis("Horizontal"); // Get the Axis Horizontal
		float inputy = Input.GetAxis("Vertical"); // Get the Axis Vertical

		movement = new Vector2 (speed.x * inputx, speed.y * inputy); // Move the object per direction X speed

		// Shooting

		bool shot = Input.GetButtonDown("Fire1");
		shot |= Input.GetButtonDown("Fire2");

		if (shot) {
			if(weapons != null) {
				// false because the player is not an enemy

				weapons.Attack(false);
			}
		}
	}

	void FixedUpdate(){
		rigidbody2D.velocity = movement; // Move the obeject
	}

}
