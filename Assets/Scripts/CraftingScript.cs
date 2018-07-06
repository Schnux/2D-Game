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
        item = FindObjectOfType<iron_ingot>(); //Ingot item dann noch einfügen
        inventory.AddItem(item);
    }
    public void CopperIngotCraften()
    {
        item = FindObjectOfType<Copper_Ore>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<copper_ingot>(); //ingot item dann noch einfügen
        inventory.AddItem(item);
    }
    public void HolzCraften()
    {
        item = FindObjectOfType<Log>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<plank>(); 
        inventory.AddItem(item);
        inventory.AddItem(item);
        inventory.AddItem(item);
        inventory.AddItem(item);
    }
    public void StickCraften()
    {
        item = FindObjectOfType<plank>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<sticks>(); 
        inventory.AddItem(item);
        inventory.AddItem(item);
        inventory.AddItem(item);
        inventory.AddItem(item);
    }
    public void ShovelCraften()
    {
        item = FindObjectOfType<sticks>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<iron_ingot>();
        inventory.RemoveItem(item);
        item = FindObjectOfType<shovel>();
        inventory.AddItem(item);
    }
    public void PickAxeCraften()
    {
        item = FindObjectOfType<sticks>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<iron_ingot>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<pickaxe>();
        inventory.AddItem(item);
    }
    public void AxeCraften()
    {
        item = FindObjectOfType<sticks>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<iron_ingot>();
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        inventory.RemoveItem(item);
        item = FindObjectOfType<axe>();
        inventory.AddItem(item);
    }
}
