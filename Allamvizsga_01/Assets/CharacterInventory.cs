using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    private List<InventorySlot> inventorySlotList;

    public CharacterInventory()
    {
        inventorySlotList = new List<InventorySlot>();
       
        Debug.Log(inventorySlotList.Count);
    }

    public void AddItem(ItemSlot item)
    {
        //inventorySlotList.Add(item);
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
