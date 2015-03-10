﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dead : MonoBehaviour {

	public bool won = false;
	public bool done = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distTwo = Vector3.Distance(GameObject.Find("SpaceShip").transform.position,GameObject.Find("Player").transform.position);
		string textBuffer = "";

		if (GameObject.Find("Player").GetComponent<Hurtable>().health < 0f){
			textBuffer += "Dang.";
			textBuffer += "You're dead.\n";
			textBuffer += "Try Again? [R]";
			done = true;
			if (Input.GetKeyDown(KeyCode.R)){
				Application.LoadLevel ("MidTermPrototype");
			}
		}
		if (distTwo < 50 && GameObject.Find("Keys").GetComponent<KeyPickUp>().item == true){
			textBuffer = "You Won! You get into your ship and don't die!";
			won = true;
		}


		GetComponent<Text>().text = textBuffer;
	}
}
