using UnityEngine;
using System.Collections;

public class Hurtable : MonoBehaviour {

	public float health = 100f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("TextTwo").GetComponent<Objective>().start == true){
		health -= .1f*Time.deltaTime; 

		if ( health <= 0f ){
			//Destroy ( gameObject );

		}
		if (GameObject.Find("TextThree").GetComponent<Dead>().won == true){
			health = 100f;
		}
		}

	}
}
