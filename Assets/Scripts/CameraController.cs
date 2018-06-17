using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{

	private float moveSpeed = 20.0f;
	public Transform target;
	
	void Update()
	{
		Vector3 newPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
	}




}
