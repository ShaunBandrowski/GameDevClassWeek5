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

		if (dist < 1000 && rescue == false){
			
			textBuffer = "Hint: You remember being north of your ship earlier in the day. Near the flowing lava river.";
		}
		if (dist < 600 && rescue == false){

			textBuffer = "Hint: Those oxygen tanks seem like breadcrumbs leading to where you were earlier today.";
		}
		if(dist<100 ){
			
			textBuffer = "Hint: That looks like your keys!";

			rescue = true;

			
		
		}else{
			textBuffer +="";
		}

		GetComponent<Text>().text = textBuffer;  
		
	}
}
