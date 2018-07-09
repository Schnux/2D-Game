using UnityEngine;
using System.Collections;

public class Leaves_Collider : MonoBehaviour {
	private mine_Leaves Mine_Leaves;
	//private mine_Dirt Mine_Dirt;
	//private mine_Grass Mine_Grass;
	//public mine_Iron_Ore Mine_Iron_Ore;
	//public mine_Copper_Ore Mine_Copper_Ore;

	void Start(){

		Mine_Leaves = GetComponent<mine_Leaves> ();
		//Mine_Dirt = GetComponent<mine_Dirt> ();
		//Mine_Grass = GetComponent<mine_Grass> ();
		//Mine_Iron_Ore = GetComponent<mine_Iron_Ore> ();
		//Mine_Copper_Ore = GetComponent<mine_Copper_Ore> ();
	}
	void OnTriggerEnter2D(Collider2D collidedObject){

		switch (collidedObject.tag) {


		case "Player":
			Controller.landed = true;
			Mine_Leaves.breakable = true;
			//Mine_Dirt.breakable = true;
			//Mine_Grass.breakable = true;
			//Mine_Iron_Ore.breakable = true;
			//Mine_Copper_Ore.breakable = true;
			break;


		}
	}

	void OnTriggerExit2D(Collider2D collidedObject){

		switch (collidedObject.tag) {


		case "Player":

			//Mine_Dirt.breakable = false;
			Mine_Leaves.breakable = false;
			//Mine_Grass.breakable = false;
			//Mine_Iron_Ore.breakable = false;
			//Mine_Copper_Ore.breakable = false;
			break;

		}
	}

}
