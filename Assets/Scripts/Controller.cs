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
	private int anzahl;

    private float jumpDirection;
	public static bool landed = true;
	public static bool death = false;
	public static bool testrange = false;
	public Rigidbody2D rb;
	private Vector2 velocity;
	private InventoryItemBase inventoryItemBase;
	public Chunk chunk;
	public InventoryItemBase item;
	private Inventory inventory;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		chunk = GetComponent<Chunk> ();
		inventory = FindObjectOfType<Inventory>();


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
			item = FindObjectOfType<Dirt> ();
			anzahl = inventory.dirtcraft;
			break;
		case "Grass":
			newBlock = Grass;
			item = FindObjectOfType<Grass> ();
			anzahl = inventory.grasscraft;
			break;
		case "Stone":
			newBlock = Stone;
			item = FindObjectOfType<Stone> ();
			anzahl = inventory.stonecraft;
			break;
		case "Iron_Ore":
			newBlock = Iron_Ore;
			item = FindObjectOfType<Iron_Ore> ();
			anzahl = inventory.ironorecraft;
			break;
		case "Copper_Ore":
			newBlock = Copper_Ore;
			item = FindObjectOfType<Copper_Ore> ();
			anzahl = inventory.copperorecraft;
			break;
		case "log":
			newBlock = Log;
			item = FindObjectOfType<Log> ();
			anzahl = inventory.logcraft;
			break;
		case "leaves":
			newBlock = Leaves;
			item = FindObjectOfType<Leaves> ();
			anzahl = inventory.leavescraft;
			break;
		case "plank":
			newBlock = Plankes;
			item = FindObjectOfType<plank> ();
			anzahl = inventory.plankscraft;
			break;
		}



	
		if (Input.GetMouseButtonDown (1)) {

			//Ray2D ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(anzahl >= 1){
			Vector3 position;
			Instantiate (newBlock);
			newBlock.transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			position = newBlock.transform.localPosition;
			position = new Vector3(newBlock.transform.position.x, newBlock.transform.position.y, 0f);
			newBlock.transform.localPosition = position;
			inventory.RemoveItem(item);
		}
	
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
