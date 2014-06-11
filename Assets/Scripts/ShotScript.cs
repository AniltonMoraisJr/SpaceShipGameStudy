using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	// Variables

	public int damage = 1; // Shot Damage 

	public bool isEnemyShot = false; // Projectile damage enemy or player

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20); //Limited time to live to avoid any leak
		// 20 sec
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
