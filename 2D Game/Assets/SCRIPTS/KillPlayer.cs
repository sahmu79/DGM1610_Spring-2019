using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for Initialization
	void Start () {
		levelManager = FindObjectOfType <LevelManager>();

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			levelManager.respawnPlayer();
		}
	}
}