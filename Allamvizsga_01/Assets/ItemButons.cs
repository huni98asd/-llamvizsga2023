using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButons : MonoBehaviour
{
    public CharacterInventory characterInventory;
    public Item[] itemToPickup;

    public void PickupItem(int id)
    {
        bool result = characterInventory.AddItem(itemToPickup[id]);
        if(result == true)
        {
            Debug.Log("Item added");
        }
        else
        {
            Debug.Log("Inventory full");
        }
    }

   
}
