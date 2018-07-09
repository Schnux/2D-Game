using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int SLOTS = 10;

    private IList<InventorySlot> mSlots = new List<InventorySlot>();

    public event EventHandler<InventoryEventArgs> ItemAdded;
    public event EventHandler<InventoryEventArgs> ItemRemoved;
    public event EventHandler<InventoryEventArgs> ItemUsed;
    public int ironorecraft = 0;  //Crafting variablen
    public int copperorecraft = 0;
    public int logcraft = 0;
    public int plankscraft = 0;
    public int ironingotcraft = 0;
    public int stickscraft = 0;

    public Inventory()
    {
        for (int i = 0; i < SLOTS; i++)
        {
            mSlots.Add(new InventorySlot(i));
        }
    }

    private InventorySlot FindStackableSlot(InventoryItemBase item)
    {
        foreach (InventorySlot slot in mSlots)
        {
            if (slot.IsStackable(item))
                return slot;
        }
        return null;
    }

    private InventorySlot FindNextEmptySlot()
    {
        foreach (InventorySlot slot in mSlots)
        {
            if (slot.IsEmpty)
                return slot;
        }
        return null;
    }

    public void AddItem(InventoryItemBase item)
    {
        InventorySlot freeSlot = FindStackableSlot(item);
        if (freeSlot == null)
        {
            freeSlot = FindNextEmptySlot();
        }
        if (freeSlot != null)
        {
            freeSlot.AddItem(item);

            if (ItemAdded != null)
            {
                ItemAdded(this, new InventoryEventArgs(item));
                if (item == FindObjectOfType<Iron_Ore>())          //Wenn Items geadded werden,variable fuer craftingcheck erhoehen
                { ironorecraft = ironorecraft + 1; }
                if (item == FindObjectOfType<Copper_Ore>())
                { copperorecraft = copperorecraft + 1; }
                if (item == FindObjectOfType<Log>())
                { logcraft = logcraft + 1; }
                if (item == FindObjectOfType<plank>())
                { plankscraft = plankscraft + 1; }
                if (item == FindObjectOfType<iron_ingot>())
                { ironingotcraft = ironingotcraft + 1; }
                if (item == FindObjectOfType<sticks>())
                { stickscraft = stickscraft + 1; }
            }

        }
    }

    internal void UseItem(InventoryItemBase item)
    {
        if (ItemUsed != null)
        {
            ItemUsed(this, new InventoryEventArgs(item));
        }

        item.OnUse();
    }

    public void RemoveItem(InventoryItemBase item)
    {
        foreach (InventorySlot slot in mSlots)
        {
            if (slot.Remove(item))
            {
                if (ItemRemoved != null)
                {
                    ItemRemoved(this, new InventoryEventArgs(item));
                    if (item == FindObjectOfType<Iron_Ore>())          //Wenn Items removed werden,variable fuer craftingcheck verkleinern
                    { ironorecraft = ironorecraft - 1; }
                    if (item == FindObjectOfType<Copper_Ore>())
                    { copperorecraft = copperorecraft - 1; }
                    if (item == FindObjectOfType<Log>())
                    { logcraft = logcraft - 1; }
                    if (item == FindObjectOfType<plank>())
                    { plankscraft = plankscraft - 1; }
                    if (item == FindObjectOfType<iron_ingot>())
                    { ironingotcraft = ironingotcraft - 1; }
                    if (item == FindObjectOfType<sticks>())
                    { stickscraft = stickscraft - 1; }


                }
                break;
            }

        }
    }
}
