using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


	public float playerWalkSpeed;
	public float maxSpeed;
	public float playerJumpForceHorizontal;
	public float playerJumpForceVertical;
    public float jumpForce;
    public float High;
	private GameObject newBlock;
	public GameObject Dirt;
	public GameObject Grass;
	public GameObject Stone;
	public GameObject Iron_Ore;
	public GameObject Copper_Ore;
	public GameObject Log;
	public GameObject Leaves;
	public GameObject Plankes;
	public static string Material_Name;


    private float jumpDirection;
	public static bool landed = true;
	public static bool death = false;
	public static bool testrange = false;
	public Rigidbody2D rb;
	private Vector2 velocity;
	private InventoryItemBase inventoryItemBase;
	public Chunk chunk;


	void Start () {
		rb = GetComponent<Rigidbody2D>();
		chunk = GetComponent<Chunk> ();



	}
	public void Name(string name){
		Material_Name = name;

	}
	void Update(){


		if (Input.GetButtonDown ("Jump") && landed == true) {
			rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
			landed = false;
		}

		switch (Material_Name) {
		case "Dirt":
			newBlock = Dirt;
			break;
		case "Grass":
			newBlock = Grass;
			break;
		case "Stone":
			newBlock = Stone;
			break;
		case "Iron_Ore":
			newBlock = Iron_Ore;
			break;
		case "Copper_Ore":
			newBlock = Copper_Ore;
			break;
		case "log":
			newBlock = Log;
			break;
		case "leaves":
			newBlock = Leaves;
			break;
		case "plank":
			newBlock = Plankes;
			break;
		}



	
		if (Input.GetMouseButtonDown (1)) {

			//Ray2D ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
			Vector3 position;
			Instantiate (newBlock);
			newBlock.transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			position = newBlock.transform.localPosition;
			position = new Vector3(newBlock.transform.position.x, newBlock.transform.position.y, 0f);
			newBlock.transform.localPosition = position;
		}
	


			
	}





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
