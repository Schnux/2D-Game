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
    public void IronIngotCraften()
    {
        item = FindObjectOfType<Iron_Ore>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<Copper_Ore>(); //Ingot item dann noch einfügen
        inventory.AddItem(item);
    }
    public void CopperIngotCraften()
    {
        item = FindObjectOfType<Copper_Ore>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<Iron_Ore>(); //ingot item dann noch einfügen
        inventory.AddItem(item);
    }
    public void HolzCraften()
    {
        item = FindObjectOfType<Log>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<Iron_Ore>(); //holz dann noch einfügen
        inventory.AddItem(item);
    }
}
