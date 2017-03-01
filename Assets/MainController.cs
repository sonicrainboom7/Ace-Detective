using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MainController : MonoBehaviour {
	// Button variables.
	PointerController left;
	PointerController right;
	PointerController action;
	// inventory system buttons and vectors.
	private Button a;
	private Button b;
	private Button c;
	private Button d;
	private Button e;
	private Button f;
	private Button g;
	private Button h;
	private Button i;
	private Button j;
	private Button k;
	private Button l;
	Vector3 aV;
	Vector3 bV;
	Vector3 cV;
	Vector3 dV;
	Vector3 eV;
	Vector3 fV;
	Vector3 gV;
	Vector3 hV;
	Vector3 iV;
	Vector3 jV;
	Vector3 kV;
	Vector3 lV;
	Vector3 outOfSight;
	Sprite backgroundImage;
	// Gameobject variables.
	GameObject character;
	GameObject bottle;
	GameObject house1Npc;
	GameObject overworldNpc;
	// list for rooms and room booleans.
	private Rooms nextRoom;
	private List<Rooms> rooms = new List<Rooms> (); 
	private SpriteRenderer roomPicture;
	private Door trigger;
	private bool overworld1 = false;
	private bool pharmacyBool = false;
	private bool overworld2 = false;

	// Use this for initialization, GetComponent<PointerController>
	void Start () {
		outOfSight = new Vector3 (-1000, -1000);
		overworldNpc = GameObject.Find ("OverworldNPC");
		overworldNpc.transform.position = new Vector3 (1000, 10000, 0);
		// declaration of buttons and gameobjects.
		left = GameObject.Find ("Left").GetComponent<PointerController> ();
		right = GameObject.Find ("Right").GetComponent<PointerController> ();
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
		character = GameObject.Find ("Character");
		bottle = GameObject.Find ("Bottle");
		house1Npc = GameObject.Find ("House1NPC");
		roomPicture = GameObject.Find ("BackgroundPic").GetComponent<SpriteRenderer> ();
		// Get sprite for every room in game.
		Rooms house1 = new Rooms ("house1", "House1");
		Rooms overworld = new Rooms ("overworld", "Overworld");
		Rooms pharmacy = new Rooms ("pharmacy", "Pharmacy");
		Rooms house2 = new Rooms ("house2", "House2");
		// Add rooms to list.
		rooms.Add (overworld);
		rooms.Add (pharmacy);
		rooms.Add (overworld);
		rooms.Add (house2);
		// set next room for every room in the game.
		house1.setNextRoom (overworld);
		overworld.setNextRoom (pharmacy);
		pharmacy.setNextRoom (overworld);
		overworld.setNextRoom (house2);
		trigger = GameObject.Find ("Door").GetComponent<Door> ();
	

	}
	// Update is called once per frame: f means float point type
	void Update () {
		if (action.getPressed () && trigger.GettriggerCheck () && (overworld2)) {
			Sprite house2 = Resources.Load ("House2", typeof(Sprite)) as Sprite;
			Debug.Log (this.roomPicture);
			this.roomPicture.sprite = house2;
			character.transform.position = new Vector3 (-8, -4, 0);
			character.transform.localScale = new Vector3 (1.5f, 1.5f);
			trigger.transform.position = new Vector3 (5, 144, 0);
			trigger.transform.localScale = new Vector3 (3, 3);
		}
		else if (action.getPressed() && trigger.GettriggerCheck () && (pharmacyBool)) {
			Sprite overworld = Resources.Load("Overworld", typeof(Sprite)) as Sprite;
			Debug.Log (this.roomPicture);
			this.roomPicture.sprite = overworld;
			character.transform.position = new Vector3 (1.4f, -4, 0);
			character.transform.localScale = new Vector3 (1.5f, 1.5f);
			trigger.transform.position = new Vector3 (8.2f, -4, 0);
			trigger.transform.localScale = new Vector3 (3, 3);
			overworld2 = true;
		}
		else if (action.getPressed () && trigger.GettriggerCheck () && (overworld1)) {
			Sprite pharmacy = Resources.Load ("Pharmacy", typeof(Sprite)) as Sprite;
			Debug.Log (this.roomPicture);
			this.roomPicture.sprite = pharmacy;
			character.transform.position = new Vector3 (-7, -4, 0);
			character.transform.localScale = new Vector3 (1.5f, 1.5f);
			trigger.transform.position = new Vector3 (-8, -4, 0);
			trigger.transform.localScale = new Vector3 (5, 5);
			pharmacyBool = true;
		}
		else if (action.getPressed() && trigger.GettriggerCheck()) {
			Sprite overworld = Resources.Load("Overworld", typeof(Sprite)) as Sprite;
			Debug.Log (this.roomPicture);
			this.roomPicture.sprite = overworld;
			overworldNpc.transform.position = new Vector3 (-1, -4, 0);
			Destroy (bottle);
			Destroy (house1Npc);
			character.transform.position = new Vector3 (-4, -4, 0);
			character.transform.localScale = new Vector3 (1.5f, 1.5f);
			trigger.transform.position = new Vector3 (1.4f, -4, 0);
			trigger.transform.localScale = new Vector3 (3, 3);
			overworld1 = true;

		}
			
		// Character moves left.
		if (left.getPressed()) {
			character.transform.Translate (-0.1f,0,0);    
		}
		// Character moves right.
		if (right.getPressed()) {
			character.transform.Translate (0.1f,0,0);    
		}
	}
}
