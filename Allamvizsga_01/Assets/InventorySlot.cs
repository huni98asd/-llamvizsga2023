using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{

    public enum ItemType
    {
        Right,
        Left,
        Jump
    }

    public ItemType itemType;

    private Image image;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;

            image.sprite.name =  draggableItem.image.sprite.name;
            //Debug.Log(transform.GetChild(image.sprite.name));
            //Debug.Log(draggableItem.itemName );
            Debug.Log(transform.GetChild( ) )
            //Debug.Log(transform.GetChild(image.sprite.name));
            //if(itemType.Equals  )
        }
    }
}
