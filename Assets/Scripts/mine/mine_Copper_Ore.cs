using UnityEngine;
using System.Collections;

public class mine_Copper_Ore : MonoBehaviour {

	public GameObject Material;
	public bool Range = false;
	public int touching = 0;
	public bool breakable = false;
	public Inventory inventory;
	public InventoryItemBase item;






	void Start () {
		nextto ();
		item = FindObjectOfType<Copper_Ore> ();
		inventory = FindObjectOfType<Inventory> ();

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

			if (item != null){
				inventory.AddItem(item);
				inventory.RemoveItem (item);
			}



		}

	}



	public void nextto(){


		Collider2D[] hits = Physics2D.OverlapCircleAll (transform.position, 1f);

		foreach(Collider2D hit in hits){

			if (hit.tag == "Ground") {

				this.touching = this.touching + 1;

			}

		}
	}
}