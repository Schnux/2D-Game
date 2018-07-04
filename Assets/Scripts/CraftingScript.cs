using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingScript : MonoBehaviour {
    private Inventory inventory;
    public InventoryItemBase item;
    // Use this for initialization
    void Start() {
        
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update() {

    }
    public void Craften()
    {
        item = FindObjectOfType<Copper_Ore>();
        inventory.AddItem(item);
    }
    public void Craftenzwei()
    {
        item = FindObjectOfType<Iron_Ore>();
        inventory.AddItem(item);
    }
}
