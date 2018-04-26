using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


	public float playerWalkSpeed;
	public float playerJumpForceHorizontal;
	public float playerJumpForceVertical;
	private float jumpDirection;
	public static bool landed = true;
	public static bool death = false;
	public static bool testrange = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 localScale = transform.localScale;
		Vector3 respawn = GameObject.Find("respawn").transform.position;

		//Links
		if (Input.GetKey ("a")) {
			jumpDirection = -1.0f;			
			transform.Translate (new Vector3 ((playerWalkSpeed * -1.0f) * Time.deltaTime, 0.0f, 0.0f));


			if(localScale.x > 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale  = localScale;
			}

		}
		//Rechts
		if (Input.GetKey ("d")) {
			jumpDirection = 1.0f;
			transform.Translate(new Vector3(playerWalkSpeed * Time.deltaTime, 0.0f, 0.0f));
			
			if(localScale.x < 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale = localScale;              
			}
		}
		if (Input.GetKey ("space") && landed == true) {

						rigidbody2D.AddForce (new Vector2 (jumpDirection * playerJumpForceHorizontal, playerJumpForceVertical));
			//new WaitForSeconds(5f);
			landed = false;
	
		}
		if (death == true) {
			transform.rotation = Quaternion.identity;
			transform.localPosition = respawn;	
			if(localScale.x < 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale = localScale;              
			}

			death = false;

		}

	}
}
