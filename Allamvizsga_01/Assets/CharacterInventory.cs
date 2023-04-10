using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;
   

    public bool AddItem(Item item)
    {
        //inventorySlotList.Add(item);
        for(int i = 0; i< inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            DraggableItem draggableItem = slot.GetComponentInChildren<DraggableItem>();
            if(draggableItem == null)
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

   /* public List<ItemSlot> GetItemList()
    {
        return inventorySlotList;
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(inventorySlotList != null )
           // Debug.Log("VAALAMI");
    }
}
