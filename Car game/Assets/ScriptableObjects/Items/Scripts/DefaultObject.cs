using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="New Default Object",menuName = "Inventory System/Items/Fuel")]
public class DefaultObject : ItemObject
{
    public void Awake()
    {
        type=ItemType.Fuel;
    }
}
