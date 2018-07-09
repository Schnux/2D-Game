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

        if (inventory.ironorecraft >= 1)
        {
            item = FindObjectOfType<Iron_Ore>();
            inventory.RemoveItem(item);
            item = FindObjectOfType<iron_ingot>(); //Ingot item dann noch einfügen
            inventory.AddItem(item);
        }
        
    }
    public void CopperIngotCraften()
    {
        if (inventory.copperorecraft >= 1)
        {
            item = FindObjectOfType<Copper_Ore>();
            inventory.RemoveItem(item);
            item = FindObjectOfType<copper_ingot>(); //ingot item dann noch einfügen
            inventory.AddItem(item);
        }
    }
    public void HolzCraften()
    {
        if (inventory.logcraft >= 1)
        {
            item = FindObjectOfType<Log>();
            inventory.RemoveItem(item);
            item = FindObjectOfType<plank>();
            inventory.AddItem(item);
            inventory.AddItem(item);
            inventory.AddItem(item);
            inventory.AddItem(item);
        }
    }
    public void StickCraften()
    {
        if (inventory.plankscraft >= 2)
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
    }
    public void ShovelCraften()
    {
        if (inventory.ironingotcraft >= 1 && inventory.stickscraft >= 2)
        {
            item = FindObjectOfType<sticks>();
            inventory.RemoveItem(item);
            inventory.RemoveItem(item);
            item = FindObjectOfType<iron_ingot>();
            inventory.RemoveItem(item);
            item = FindObjectOfType<shovel>();
            inventory.AddItem(item);
        }
    }
    public void PickAxeCraften()
    {
        if (inventory.ironingotcraft >= 3 && inventory.stickscraft >= 2)
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
    }
    public void AxeCraften()
    {
        if (inventory.ironingotcraft >= 3 && inventory.stickscraft >= 2)
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
}
