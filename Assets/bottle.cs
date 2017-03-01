using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle : MonoBehaviour {

	PointerController action;
	bool triggerBottle = false; 

	void Start (){
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
	}
	void OnTriggerEnter2D(Collider2D c){
		this.triggerBottle = true;
		//Debug.Log (c);
		Character character = c.gameObject.GetComponent <Character> ();
		character.addItem (gameObject.name);

	}
	public bool GettriggerCheck() {
		return this.triggerBottle;
	}
}