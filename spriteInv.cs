using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spriteInv : MonoBehaviour
{
	GameObject inventorysprite;
	Vector3 InvLocation;
	Vector3 CloseBtnLocation;
	Vector3 BottleBtnLocation;
	Vector3 GasolineBtnLocation;
	Vector3 FireplaceBtnLocation;
	private Button tavaraNappain;
	private Button CloseBtn;
	private Button BottleBtn;
	private Button GasolineBtn;
	private Button FireplaceBtn;
	bool bottletext;

	void Start (){
		inventorysprite = GameObject.Find ("Inventory");
		tavaraNappain = GameObject.Find ("Inv").GetComponent<Button> ();
		CloseBtn = GameObject.Find ("Close").GetComponent<Button> ();
		BottleBtn = GameObject.Find ("Bottle").GetComponent<Button> ();
		GasolineBtn = GameObject.Find ("Gasoline").GetComponent<Button> ();
		FireplaceBtn = GameObject.Find ("Fireplace").GetComponent<Button> ();
		InvLocation = inventorysprite.transform.position = new Vector3 (-4, 0);
		inventorysprite.transform.localPosition = new Vector3 (-1000, -1000); 
		CloseBtnLocation = CloseBtn.transform.localPosition = new Vector3 (-137, -90);
		CloseBtn.transform.localPosition = new Vector3 (-1000, -1000);
		BottleBtnLocation = BottleBtn.transform.position = new Vector3 (-137, 120);
		BottleBtn.transform.localPosition = new Vector3 (-1000, -1000);
		GasolineBtnLocation = GasolineBtn.transform.position = new Vector3 (-137, 90);
		GasolineBtn.transform.localPosition = new Vector3 (-1000, -1000);
		FireplaceBtnLocation = FireplaceBtn.transform.position = new Vector3 (-137, 60);
		FireplaceBtn.transform.localPosition = new Vector3 (-1000, -1000);
		tavaraNappain.onClick.AddListener (() => OpenInventory ());
		CloseBtn.onClick.AddListener (() => CloseInventory ());

	}
	void OpenInventory () {
		Debug.Log ("testi");
		Debug.Log (bottletext);
		inventorysprite.transform.localPosition = InvLocation;
		CloseBtn.transform.localPosition = CloseBtnLocation;
		if (bottletext) {
			BottleBtn.transform.localPosition = BottleBtnLocation;
		}
		GasolineBtn.transform.localPosition = GasolineBtnLocation;
		FireplaceBtn.transform.localPosition = FireplaceBtnLocation;
		

	}
	void CloseInventory() {
		inventorysprite.transform.localPosition = new Vector3 (-1000, -1000); 
		CloseBtn.transform.localPosition = new Vector3 (-1000, -1000);
		BottleBtn.transform.localPosition = new Vector3 (-1000, -1000);
		GasolineBtn.transform.localPosition = new Vector3 (-1000, -1000);
		FireplaceBtn.transform.localPosition = new Vector3 (-1000, -1000);
				
				}

	}
