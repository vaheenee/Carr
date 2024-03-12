using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> conatiner = new List<InventorySlot>();
    public void AddItem(ItemObject _item,int _amount)
    {
        bool hasItem=false;
    }
}
[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public InventorySlot(ItemObject _item , int _amount)
    {
        item=_item;
        amount=_amount;
    }
    public void AddAmount(int value)
    {
        amount+=value;
    }
}