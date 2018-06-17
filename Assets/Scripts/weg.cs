using UnityEngine;
using System.Collections;

public class weg : MonoBehaviour {

	public GameObject Material;
	public bool Range = false;
	public int touching = 0;
	public bool breakable = false;






	void Start () {
		nextto ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (this.touching < 8) {

			this.Range = true;

		}
		this.touching = 0;
		nextto ();


		}
	void OnMouseUp(){
		
		if (this.Range == true && this.breakable == true) {
				Destroy (Material);
		}
	
	}

	/*void OnCollisionEnte2D(Collider2D collidedObject){

		if (collidedObject.tag == "Ground") {


	
			this.touching = this.touching + 1;


		} 

	




}*/

	public void nextto(){

	/*	if (Mathf.Abs(Material.transform.position.x - Material.transform.position.x)< 1 ) {
			this.touching = this.touching + 1;
			Debug.LogError (this.transform.position.x - Material.transform.position.x);
		}
		if (Mathf.Abs(Material.transform.position.y - Material.transform.position.y)< 1 ) {
			this.touching = this.touching + 1;
			Debug.LogError (touching);
		}
		*/
		Collider2D[] hits = Physics2D.OverlapCircleAll (transform.position, 1f);

		foreach(Collider2D hit in hits){

			if (hit.tag == "Ground") {

				this.touching = this.touching + 1;
				//Debug.LogError (touching);
			}

		}
	}
}