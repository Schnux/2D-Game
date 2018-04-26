using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collidedObject){
		
		switch (collidedObject.tag) {
			
			
		case "Player":
			Controller.landed = true;

			break;
			
		}
	}

}
