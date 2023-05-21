using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]

public class Item : ScriptableObject
{

    [Header("Only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;

    //public ItemType itemType;
    //public int amount;

   /* public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Jump: return ItemAssets.Instance.jumpSprite;
            case ItemType.Left: return ItemAssets.Instance.goLeftSprite;
            case ItemType.Right: return ItemAssets.Instance.goRightSprite;
        }
    }*/
}
    public enum ItemType
    {
        Right,
        Left,
        Jump,
        Function1,
        Function2
    }

    public enum ActionType
    {
        Go_Left,
        Go_Right,
        Jump,
        Add_Function1,
        Add_Function2
}

   

