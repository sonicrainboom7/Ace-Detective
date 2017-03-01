using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	PointerController action;
	bool TriggerCheck = false;


	void Start (){
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
	}
	void OnTriggerEnter2D(Collider2D c){
		this.TriggerCheck = true;
	}
	void OnTriggerExit2D(Collider2D c){
		this.TriggerCheck = false;
	}
	public bool GettriggerCheck() {
		return this.TriggerCheck;
	}
}
