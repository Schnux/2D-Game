using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EItemType
{
    Default,
    Consumable,
    Weapon
}

public class InteractableItemBase : MonoBehaviour

{
    public string Name;

    public Sprite Image;

    public string InteractText = "Press F to pickup the item";

    public EItemType ItemType;

    public virtual void OnInteract()
    {
    }


}

public class InventoryItemBase : InteractableItemBase
{
	Controller controller = new Controller ();
	//private Controller controller;
	public InventorySlot Slot
    {
        get; set;
    }

	public virtual void OnUse()
    {
        transform.localPosition = PickPosition;
        transform.localEulerAngles = PickRotation;
		GetName (Name);

    }

    public virtual void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
            gameObject.transform.eulerAngles = DropRotation;
        }
    }

    public virtual void OnPickup()
    {
        Destroy(gameObject.GetComponent<Rigidbody>());
        gameObject.SetActive(false);
        
    }

    public Vector3 PickPosition;

    public Vector3 PickRotation;

    public Vector3 DropRotation;

    public bool UseItemAfterPickup = false;

	public void GetName(string name){
		switch (name) {
		case "Dirt":
			controller.Name(name);
			break;
		
		case "Grass":
			controller.Name(name);
			break;
		
		case "Copper_Ore":
			controller.Name(name);
			break;

		case "Stone":
			controller.Name(name);
			break;

		case "Iron_Ore":
			controller.Name(name);
			break;

		case "pickaxe":
			controller.Name(name);
			break;

		case "axe":
			controller.Name(name);
			break;

		case "copper_ingot":
			controller.Name(name);
			break;

		case "iron_ingot":
			controller.Name(name);
			break;

		case "leaves":
			controller.Name(name);
			break;

		case "log":
			controller.Name(name);
			break;
		
		case "plank":
			controller.Name(name);
			break;

		case "shovel":
			controller.Name(name);
			break;

		case "sticks":
			controller.Name(name);
			break;
		}




    }


}
