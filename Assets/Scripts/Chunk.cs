using UnityEngine;
using System.Collections;

public class Chunk : MonoBehaviour {

	public int width;
	public float hightmultiplier;
	public float smooth;
	public int hightAddition;
	public GameObject Grass;
	public GameObject Dirt;
	public GameObject Stone;
	public GameObject Iron_ore;
	public GameObject Copper_ore;

	public float chanceIron;
	public float chanceCopper;

	public float seed;

	void Start () {
		


		Generate ();

	}

	public void Generate () {
	
		for (int i = 0; i < width; i++) {

			int h = Mathf.RoundToInt(Mathf.PerlinNoise(1f + seed, i/smooth) * hightmultiplier) + hightAddition;

			for(int j = 0;j < h; j++){
				GameObject selectedTile;
				if(j < h-4){
					selectedTile = Stone;
				}else if(j < h-1){
					selectedTile = Dirt;
				}else {
					selectedTile = Grass;
				}
		
				GameObject newTile =  Instantiate(selectedTile,Vector3.zero,Quaternion.identity) as GameObject;
				newTile.transform.parent = this.gameObject.transform;
				newTile.transform.localPosition = new Vector3 (i, j);

			}


  		}

		Resources ();
	
	}

	public void Resources(){
		
		foreach (GameObject t in GameObject.FindGameObjectsWithTag("Stone")) {
			if(t.transform.parent == this.gameObject.transform){
			float r = Random.Range (0f, 100f);
			GameObject selectedTile = null;
			if (r < chanceCopper) {

				selectedTile = Copper_ore;

			} else if(r < chanceIron){

				selectedTile = Iron_ore;
		
		}
	
			if (selectedTile != null) {
				GameObject newResource= Instantiate (selectedTile, t.transform.position, Quaternion.identity) as GameObject;
				newResource.transform.parent = transform;
				Destroy (t);
			}
	}
}
}

}