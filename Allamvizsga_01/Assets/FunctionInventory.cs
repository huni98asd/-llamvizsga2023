using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionInventory : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    int selectedSlot = -1;


  

    public bool AddItem(Item item)
    {
        //inventorySlotList.Add(item);
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            DraggableItem draggableItem = slot.GetComponentInChildren<DraggableItem>();
            if (draggableItem == null)
            {
                SpawnItem(item, slot);
                return true;
            }
        }
        return false;
    }

    void SpawnItem(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        DraggableItem draggableItem = newItemGo.GetComponent<DraggableItem>();
        draggableItem.InitialItem(item);
    }

    public InventorySlot[] GetSelectedItem()
    {


        return inventorySlots;
      
    }
}
