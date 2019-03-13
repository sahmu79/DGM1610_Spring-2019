using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour {

	public string stopLight;
	public bool isUtahn = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(stopLight == "Red" ){
			
			if(isUtahn){
				print("STOP! The light is RED!");	
			}
			else{
				print("Thank you for stopping at the red light!");
			}
		}
		else if(stopLight == "Yellow" ){
			
			if(isUtahn){
				print("You've got this, bruh!");
			}
			else{
				print("Thank you for preparing to stop!");
			}
		}
		else if(stopLight == "Green" ){
			
			if(isUtahn){
				print("Check your phone, turn up radio, sit at light till it turns yellow, then go!");
			}
			else{
				print("Thank you for driving properly!");
			}
		}
	}
}
