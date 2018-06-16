using UnityEngine;
using System.Collections;

public class weg : MonoBehaviour {

	public GameObject Material;
	public bool Range = false;
	public int touching = 0;






	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (this.touching == 4) {

			this.Range = true;
		
		}

		}
	void OnMouseUp(){
		
		if (this.Range == true) {
				Destroy (Material);
		}
	}

	void OnTriggerEnter2D(Collider2D collidedObject){

		if (collidedObject.tag == "Ground") {


	
			this.touching = this.touching + 1;


		} 




}
}