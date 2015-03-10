﻿using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {


	Collider thingCurrentlyInside;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// if there is a thing currently inside this trigger...
		if (thingCurrentlyInside != null){
			// then damage it
			thingCurrentlyInside.GetComponent<Hurtable>().health += 10f;
			Destroy (gameObject);
			//transform.Translate(0, -60, 0);

		}
		
	}
	
	// Unity automatically calls this function when an object using a Rigidbody
	// enters this object's trigger-collider AND it will tell you what entered it
	void OnTriggerEnter ( Collider activator ) {
		
		thingCurrentlyInside = activator; // want to remember the thing that entered the trigger
		
	}
	
	void OnTriggerExit ( Collider exiter ) {
		// "null" means nothing, empty, anscence of anything
		thingCurrentlyInside = null;
		
	}
}
