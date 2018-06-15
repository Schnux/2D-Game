﻿using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


	public float playerWalkSpeed;
	public float maxSpeed;
	public float playerJumpForceHorizontal;
	public float playerJumpForceVertical;
    public float jumpForce;
    public float High;

    private float jumpDirection;
	public static bool landed = true;
	public static bool death = false;
	public static bool testrange = false;
	public Rigidbody2D rb;
	private Vector2 velocity;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	

	}
	void Update(){
		if (Input.GetButtonDown ("Jump") && landed == true) {
			rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
			landed = false;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 localScale = transform.localScale;
		Vector3 respawn = GameObject.Find("respawn").transform.position;
        Vector2 speed = new Vector2(playerWalkSpeed * -1.0f, 0.0f);
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
		var moveVector = new Vector2 (x * playerWalkSpeed,y );
		if (x * rb.velocity.x < maxSpeed) {

			rb.AddForce (Vector2.right * x * playerWalkSpeed);

		
		}
		if (Mathf.Abs(rb.velocity.x) > maxSpeed){

			rb.velocity = new Vector2 (Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);


		}

		if (Input.GetKeyDown ("a")) {

			if(localScale.x > 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale = localScale;              
			}
		}
		if (Input.GetKeyDown ("d")) {

			if(localScale.x < 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale = localScale;              
			}
		}
        //Links
       //if (Input.GetKey ("d")) {
			//jumpDirection = -1.0f;
            /*Vector2 left = new Vector2 (playerWalkSpeed * -1.0f * Time.deltaTime, 0.0f);
           
            Vector2 move = new Vector2(moveHorizontal, moveVertical);
            //rb.velocity = move * playerWalkSpeed;
            rb.AddForce(new Vector2(playerWalkSpeed * -1.0f * Time.deltaTime, 1.0f * Time.deltaTime));*/
	
		//Vector3 move = new Vector3 (x * playerWalkSpeed, rb.velocity.y,0f);
		//rb.velocity = move;
            //rb.velocity = new Vector2(-1 * playerWalkSpeed, High);
		//rb.MovePosition(new Vector2 ((transform.position.x * playerWalkSpeed * x),rb.position));
			//rb.AddForce(Vector2.right * playerWalkSpeed, ForceMode2D.Impulse);
		//rb.MovePosition (new Vector2((transform.position.x + moveVector.x * playerWalkSpeed * Time.deltaTime),
		//	transform.position.y + 0 * playerWalkSpeed * Time.deltaTime)); 
            //transform.Translate(new Vector3((playerWalkSpeed *-1.0f)* Time.deltaTime, 0.0f, 0.0f));
            

		//}
		//Rechts
		/*if (Input.GetKey ("d")) {
			jumpDirection = 1.0f;
			transform.Translate(new Vector3(playerWalkSpeed * Time.deltaTime, 0.0f, 0.0f));
			
			if(localScale.x < 0.0f)
			{
				localScale.x *= -1.0f;
				transform.localScale = localScale;              
			}
		}*/

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