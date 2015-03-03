using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DisplayHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Oxygen: ";
		textBuffer += GameObject.Find("Player").GetComponent<Hurtable>().health.ToString();

		GetComponent<Text>().text = textBuffer;
	}
}
