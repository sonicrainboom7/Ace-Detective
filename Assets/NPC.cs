using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {
	PointerController action;
	bool btn = false;
	bool house1Npc = false;
	bool overworldNpc = false;
	bool pharmacyNpc = false;
	bool house2Npc = false;


	void Start () {
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
	}
	void OnTriggerStay2D (Collider2D a) {
		Character character = a.gameObject.GetComponent <Character> ();
		character.addItem (gameObject.name);
		Debug.Log (a); 
		if (action.getPressed() && gameObject.name == "House1NPC") {
			house1Npc = true;
		}
		if (gameObject.name == "OverworldNPC") {
			overworldNpc = true;
		}

	}
	void OnTriggerExit2D (Collider2D a) {
		house1Npc = false;
		overworldNpc = false;
	}
	void OnGUI (){
		if (house1Npc) {
			GUI.contentColor = Color.green;
			GUI.Box (new Rect (125, 180, 170, 30), "2 tuntia mukavuutta! <33");
		}
		else if (overworldNpc) {
			GUI.contentColor = Color.red;
			GUI.Box (new Rect (125, 180, 170, 130), "kerma on kaunista sunnuntaisin kesällä.");
		}
	}
}
