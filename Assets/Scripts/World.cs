using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public int width;
	public float hightmultiplier;
	public float smooth;
	public int hightAddition;
	public GameObject Grass;
	public GameObject Dirt;
	public GameObject Stone;

	public int seed;

	void Start () {
		seed = Random.Range (1, 1000);


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
		
				Instantiate(selectedTile,new Vector3(i,j),Quaternion.identity);

			}


  		}
	
	}
}
