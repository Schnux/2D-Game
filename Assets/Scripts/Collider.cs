using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {
	private weg Weg;

	void Start(){

		Weg = GetComponent<weg> ();

	}
	void OnTriggerEnter2D(Collider2D collidedObject){
		
		switch (collidedObject.tag) {
			
			
		case "Player":
			Controller.landed = true;
			Weg.breakable = true;
			break;

	
		}
	}

	void OnTriggerExit2D(Collider2D collidedObject){

		switch (collidedObject.tag) {


		case "Player":

			Weg.breakable = false;
			break;

		}
	}

}
