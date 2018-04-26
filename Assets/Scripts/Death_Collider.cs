using UnityEngine;
using System.Collections;

public class Death_Collider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collidedObject){
		
		switch (collidedObject.tag) {
			
			
		case "Player":
			Controller.death = true;
			
			break;
			
		}
}
}