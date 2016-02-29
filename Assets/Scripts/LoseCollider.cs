using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose Screen");
	}
	
	void OnCollisionEnter2D (Collision2D trigger) {
		print("Collision");
	}
}