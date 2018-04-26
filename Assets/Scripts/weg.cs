using UnityEngine;
using System.Collections;

public class weg : MonoBehaviour {

	public GameObject Material;
	public static bool Range = true;






	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		}
	void OnMouseUp()
	{
		if (Range == true) {
				Destroy (Material);
		}
	}



}
