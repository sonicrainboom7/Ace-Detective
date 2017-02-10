using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {

	PointerController left;
	PointerController right;
	PointerController action;
	//    RawImage box;
	GameObject character;

	// Use this for initialization, GetComponent<PointerController>
	void Start () {
		left = GameObject.Find ("Left").GetComponent<PointerController> ();
		right = GameObject.Find ("Right").GetComponent<PointerController> ();
		character = GameObject.Find ("Character");

	}

	// Update is called once per frame: f means float point type
	void Update () {

	/*	if (action.getPressed()) { // koodi myöhemmin
			ball.transform.Translate (0,,0);    
		}*/	
		if (left.getPressed()) {
			character.transform.Translate (-0.1f,0,0);    
		}
		if (right.getPressed()) {
			character.transform.Translate (0.1f,0,0);    
		}
	}
}
