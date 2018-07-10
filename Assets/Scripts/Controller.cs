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
	public static string Material_Name  ;
	private static string Material_Name_Old  ;
	private static string Material_Name_New;



    private float jumpDirection;
	public static bool landed = true;
	public static bool death = false;
	public static bool testrange = false;
	public Rigidbody2D rb;
	private Vector2 velocity;
	private InventoryItemBase inventoryItemBase;
	public Chunk chunk;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		chunk = GetComponent<Chunk> ();
		Material_Name_New = "1";
		Material_Name_Old = "1";



	}
	public void dirt(string name){
		Material_Name = name;
		Material_Name_New = Material_Name;
		//Debug.Log (Material_Name);

	}
	void Update(){

		if (Material_Name_New != Material_Name_Old) {

			Material_Name = Material_Name_New;
			Material_Name_Old = Material_Name_New;
			Debug.Log (Material_Name_New);
		}

		if (Input.GetButtonDown ("Jump") && landed == true) {
			rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
			landed = false;
		}
		if (Material_Name == "Dirt") {
			newBlock = Dirt;
			Debug.Log ("yes");
		}
	
		if (Input.GetMouseButtonDown (1)) {
			newBlock.transform.localPosition = Input.mousePosition;
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Instantiate (newBlock);

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
