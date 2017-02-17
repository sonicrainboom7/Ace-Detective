using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	PointerController action;
	bool triggerCheck = false; 

	void Start (){
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
	}
	void OnTriggerEnter2D(Collider2D c){
		this.triggerCheck = true;
		Debug.Log (c);
		Character character = c.gameObject.GetComponent <Character> ();
		character.addItem (gameObject.name);

	}
	public bool GettriggerCheck() {
		return this.triggerCheck;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
