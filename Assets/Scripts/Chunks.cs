using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunks : MonoBehaviour {

	public GameObject chunk;
	int chunkWidth;
	int nextChunk = 0;
	public int numberChunks;
	float seed;

	// Use this for initialization
	void Start () {

		chunkWidth = chunk.GetComponent<Chunk> ().width;

		Generate ();

	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.G)) {
			 nextChunk = chunkWidth + nextChunk;

			Generate ();

		}

	}

	public void Generate (){

		int lastX = nextChunk;
		for (int i = 0; i < numberChunks; i++) {
			seed = Random.Range (-100000f, 10000f);
			GameObject newChunk = Instantiate (chunk, new Vector3(nextChunk,0f), Quaternion.identity) as GameObject;
			newChunk.GetComponent<Chunk> ().seed = seed;
			lastX += chunkWidth;
		
		}
	
	}
}
