using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    private List<ItemSlot> itemSlotList;

    public ItemHolder()
    {
        itemSlotList = new List<ItemSlot>();
        /*
        AddItem(new Item { itemType = Item.ItemType.Jump, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Left, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Right, amount = 1 });
*/
        Debug.Log(itemSlotList.Count);
    }

    public void AddItem(ItemSlot item)
    {
        itemSlotList.Add(item);
    }

    public List<ItemSlot> GetItemList()
    {
        return itemSlotList;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
