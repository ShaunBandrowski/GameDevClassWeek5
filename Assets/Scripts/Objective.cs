using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Objective : MonoBehaviour {

	 public bool start = false;
	 public float count = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "";
		if (count == 0f){
	    textBuffer += "- Crap. The door to your giant spaceship is locked.\n";
		textBuffer += "- Press [F] to check your spacesuit for your keys.";
		}
		if (count == 1f){
			textBuffer += "- Bummer. You must've lost your keys while exploring this far out planet.\n";
			textBuffer += "- You should probably find 'em.\n";
			textBuffer += "- Press [F] to get started.";
		}
		if (count == 2f){
			textBuffer += "- You can move your space rover with the WASD keys.\n";
			textBuffer += "- Press [F] to continue...";
		}
		if (count == 3f){
			textBuffer += "- If you run out of oxygen, you're dead. FOR REAL.\n";
			textBuffer += "- Press [F] to continue...";
		}
		if (count ==4f){
			textBuffer += "- You might find some extra oxygen tanks out here on the surface, but they'll only give you so much extra air.\n";
			textBuffer += "- So find your keys and get back inside your ship where there's a ton of sweet, sweet oxygen!\n";
			textBuffer += "- Press [F] if you understand.";
		}
		if (count >=5f ){
			textBuffer += "- Find Your Keys.";
			start = true;
		}
		if (Input.GetKeyDown(KeyCode.F)){
			count+=1f;
		}
		if (GameObject.Find("Player").GetComponent<Hurtable>().health < 0f){
			textBuffer += "";
		}
        if (GameObject.Find("Keys").GetComponent<KeyPickUp>().item == true){
			textBuffer = "You got the key! Head back to your ship!";
		}
		//textBuffer += GameObject.Find("Player").GetComponent<Hurtable>().health.ToString();
		
		GetComponent<Text>().text = textBuffer;
	}
}
