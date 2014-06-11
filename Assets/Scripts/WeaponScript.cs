using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {
	// Variables

	public Transform shotPrefab; // Get the projectile prefab

	public float shootingRate = 0.25f; // Cooldown between two shots

	private float shotCooldown;

	// Use this for initialization
	void Start () {
		shotCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shotCooldown > 0) {
			shotCooldown -= Time.deltaTime;
		}
	}

	// Create a new Projectile if possible
	public void Attack(bool isEnemy){
		if (CanAttack) {
			shotCooldown = shootingRate;
			// Create a new Projectile
			var shootTransform	= Instantiate(shotPrefab) as Transform;

			// Assign Position
			shootTransform.position = this.transform.position;

			// The is enemy property

			ShotScript shot = shootTransform.gameObject.GetComponent<ShotScript>();

			if(shot != null){
				shot.isEnemyShot = isEnemy;
			}

			// Make the weapon shot always towars it

			MoveScript move = shootTransform.gameObject.GetComponent<MoveScript>();

			if(move != null){
				move.direction = this.transform.right; // towards in 2D space is the rigth of the rigth
			}
		    
		}
	}

	// Is the weapon ready to shot
	public bool CanAttack{
		get {
			return shotCooldown <= 0f;
		}
	}
}
