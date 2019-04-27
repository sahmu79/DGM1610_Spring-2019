using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;
	// Variable for Shoot/Bite
	public Animator animator;

	void Start () {
		//Load Projectile from Resources/Prefabs Folder
		projectile = Resources.Load("Prefabs/Projectile") as GameObject;

		// // Animation Reset
		// animator.SetBool("isShooting",false);

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(projectile,firePoint.position, firePoint.rotation);
			
		if(Input.GetKey (KeyCode.Space)){
			animator.SetBool("isShooting",true);
		}

		else if(Input.GetKeyUp (KeyCode.Space)){
			animator.SetBool("isWalking",false);
		}

	}
}
