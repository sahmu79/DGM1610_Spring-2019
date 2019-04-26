using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int coinValue;

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

			print("MEAT ACQUIRED");

			ScoreManager.AddPoints(coinValue);

			Destroy(gameObject);
		}

	}

	
}
