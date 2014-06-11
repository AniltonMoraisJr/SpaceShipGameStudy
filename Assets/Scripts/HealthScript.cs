using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 1; // Total of hit points

	public bool isEnemy = true;

	public void Damage(int damagecount){
		hp -= damagecount;

		if (hp <= 0) {
		  // Dead
		  Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider){
		// Is this a shot ?

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> ();

		if (shot != null) {
		  // Avoid frindly fire
		  if(shot.isEnemyShot != isEnemy){
			Damage(shot.damage);
			// Destroy the shot
				Destroy(shot.gameObject);
		  }
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
