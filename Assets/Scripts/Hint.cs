using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hint : MonoBehaviour {

	public bool rescue = false;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float dist = Vector3.Distance(GameObject.Find("Keys").transform.position,GameObject.Find("Player").transform.position);
		string textBuffer = "";


		if (GameObject.Find("Player").GetComponent<Hurtable>().health < 0f){
			textBuffer += "";
		}

		if (dist < 1550 && rescue == false){
			
			textBuffer = "Hint: You might want to keep looking around. You're super far from the keys.";
		}
		if (dist < 1000 && rescue == false){
			
			textBuffer = "Hint: You're getting closer, but the keys still elude you.";
		}
		if (dist < 700 && rescue == false){
			
			textBuffer = "Hint: The keys must be close to here.";
		}
		if (dist < 300 && rescue == false){
			
			textBuffer = "Hint: You're very close to the keys.";
		}
		if(dist<100 ){
			
			textBuffer = "Hint: That looks like your keys!";

			rescue = true;

			
		if (GameObject.Find("Player").GetComponent<Hurtable>().health < 0f){
			textBuffer = "";
		}
		if (GameObject.Find("Keys").GetComponent<KeyPickUp>().item == true){
			textBuffer = "";
		}
		}else{
			textBuffer +="";
		}

		GetComponent<Text>().text = textBuffer;  
		
	}
}
