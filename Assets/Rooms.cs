using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rooms {

	private string roomName;
	private string backroundPicture;
	private Rooms nextRoom;

	public Rooms(string roomName, string backroundPicture)
	{
		this.roomName = roomName;
		this.backroundPicture = backroundPicture;
	}
	public Rooms setNextRoom(Rooms nextRoom) {
		return this.nextRoom = nextRoom;
	} 

	public Rooms GetNextRoom(){
		return nextRoom;
	}
	public string GetRoomName(){
		return this.roomName;
	}
	public string GetBackroundPicture(){
		return this.backroundPicture;
	}
}