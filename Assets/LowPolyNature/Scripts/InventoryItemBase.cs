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

	private Controller controller;
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
		
		if (name == "Dirt")
        {
			Debug.Log ("Dirt");
        }

        if (name == "Grass")
        {
            Debug.Log("Grass");
        }

        if (name == "Copper_Ore")
        {
            Debug.Log("Copper_Ore");
        }

        if (name == "Stone")
        {
            Debug.Log("Stone");
        }

        if (name == "pickaxe")
        {
            Debug.Log("pickaxe");
        }

        if (name == "axe")
        {
            Debug.Log("axe");
        }

        if (name == "copper_ingot")
        {
            Debug.Log("copper_ingot");
        }

        if (name == "Iron_Ore")
        {
            Debug.Log("Iron_Ore");
        }

        if (name == "iron_ingot")
        {
            Debug.Log("iron_ingot");
        }

        if (name == "leaves")
        {
            Debug.Log("leaves");
        }

        if (name == "log")
        {
            Debug.Log("log");
        }

        if (name == "plank")
        {
            Debug.Log("plank");
        }

        if (name == "shovel")
        {
            Debug.Log("shovel");
        }

        if (name == "sticks")
        {
            Debug.Log("sticks");
        }
    }


}
