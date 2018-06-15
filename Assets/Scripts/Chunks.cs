using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunks : MonoBehaviour {

	public GameObject chunk;
	int chunkWidth;
	public int numberChunks;
	float seed;

	// Use this for initialization
	void Start () {

		chunkWidth = chunk.GetComponent<Chunk> ().width;
		seed = Random.Range (-100000f, 10000f);
		Generate ();

	}
	
	// Update is called once per frame
	public void Generate (){

		int lastX = -chunkWidth;
		for (int i = 0; i < numberChunks; i++) {

			GameObject newChunk = Instantiate (chunk, new Vector3(lastX + chunkWidth,0f), Quaternion.identity) as GameObject;
			newChunk.GetComponent<Chunk> ().seed = seed;
			lastX += chunkWidth;
		
		}
	
	}
}
