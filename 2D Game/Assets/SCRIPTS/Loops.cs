﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int bottles = 1;
	public bool isRaining = true;

	// Use this for initialization
	void Start () {

			// //For loop
			// for(int i=0; i < bottles; i++){
			// 	print(i +" bottles of beer on the wall ");
			// }

			while(bottles < 100){
				print(bottles +" bottles of beer on the wall ");
				bottles ++;
			}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
