using System.Collections;
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

	// 		while(bottles < 100){
	// 			print(bottles +" bottles of beer on the wall ");
	// 			bottles ++;
	// 		}
	// }
			// Do While Loop
			bool shouldContinue = false;
			
			do{
				print ("Hello World");

			}while(shouldContinue == true);
	}
			//For Each Loop
	// 		string[] strings = new string[3];

	// 		strings[0] = "First String";
	// 		strings[1] = "Second String";
	// 		strings[2] = "Third String";

	// 		foreach(string item in strings)
	// 		{
	// 			print (item);
	// 		}
	// 

	
	//Update is called once per frame
	void Update () {

	}
}
	