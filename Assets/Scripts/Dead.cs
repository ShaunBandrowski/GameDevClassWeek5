using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distTwo = Vector3.Distance(GameObject.Find("SpaceShip").transform.position,GameObject.Find("Player").transform.position);
		string textBuffer = "";

		if (GameObject.Find("Player").GetComponent<Hurtable>().health < 0f){
			textBuffer += "Dang.";
			textBuffer += "You're dead.";
		}
		if (distTwo < 50 && GameObject.Find("Keys").GetComponent<KeyPickUp>().item == true){
			textBuffer = "You Won! You get into your ship and don't die!";
		}


		GetComponent<Text>().text = textBuffer;
	}
}
