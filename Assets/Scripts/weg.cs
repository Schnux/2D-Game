using UnityEngine;
using System.Collections;

public class weg : MonoBehaviour {

	public GameObject Material;
	private bool Range = false;
	private int touching = 0;






	void Start () {
		nextto ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (this.touching == 2) {

			this.Range = true;
			//|| Material.transform.position.x == Material.transform.position.x - 1)
		}

		}
	void OnMouseUp(){
		
		if (this.Range == true) {
				Destroy (Material);
		}
	}

	void OnCollisionEnte2D(Collider2D collidedObject){

		if (collidedObject.tag == "Ground") {


	
			this.touching = this.touching + 1;


		} 

	




}

	public void nextto(){

		if (Mathf.Abs(Material.transform.position.x - Material.transform.position.x)< 1 ) {
			this.touching = this.touching + 1;
			Debug.LogError (this.Material.transform.position.x);
		}
		if (Mathf.Abs(Material.transform.position.y - Material.transform.position.y)< 1 ) {
			this.touching = this.touching + 1;
			Debug.LogError (touching);
		}
	}
}