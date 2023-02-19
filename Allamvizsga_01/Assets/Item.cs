using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Item 
{

    public enum ItemType
    {
        Right,
        Left,
        Jump
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Jump: return ItemAssets.Instance.jumpSprite;
            case ItemType.Left: return ItemAssets.Instance.goLeftSprite;
            case ItemType.Right: return ItemAssets.Instance.goRightSprite;
        }
    }
}
