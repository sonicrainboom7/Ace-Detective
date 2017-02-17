using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	PointerController left;
	PointerController right;
	PointerController action;
	Sprite backgroundImage;
	GameObject door;
	GameObject character;
	private Rooms nextRoom;
	private List<Rooms> rooms = new List<Rooms> ();  
	private SpriteRenderer roomPicture;
	private Door trigger;

	// Use this for initialization, GetComponent<PointerController>
	void Start () {
		left = GameObject.Find ("Left").GetComponent<PointerController> ();
		right = GameObject.Find ("Right").GetComponent<PointerController> ();
		action = GameObject.Find ("Action").GetComponent<PointerController> ();
		character = GameObject.Find ("Character");
		door = GameObject.Find ("Door");
		roomPicture = GameObject.Find ("BackgroundPic").GetComponent<SpriteRenderer> ();
		Rooms house1 = new Rooms ("house1", "House1");
		Rooms overworld = new Rooms ("overworld", "Overworld");
		rooms.Add (house1);
		rooms.Add (overworld);
		house1.setNextRoom (overworld);
		trigger = GameObject.Find ("Door").GetComponent<Door> ();


	}
	// Update is called once per frame: f means float point type
	void Update () {

		if (action.getPressed() && trigger.GettriggerCheck()) {
			Sprite change = Resources.Load("Overworld", typeof(Sprite)) as Sprite;
			Debug.Log (this.roomPicture);
			this.roomPicture.sprite = change;
			Destroy (door);
			character.transform.position = new Vector3 (-4, -3, 0);
			character.transform.localScale = new Vector3 (1.5f, 1.5f);
		}
		if (left.getPressed()) {
			character.transform.Translate (-0.1f,0,0);    
		}
		if (right.getPressed()) {
			character.transform.Translate (0.1f,0,0);    
		}
	}
}
