using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovemet : MonoBehaviour
{
    public CharacterController2D controller;
    public CharacterInventory characterInventory;
    public FunctionInventory functionInventory;
    public GameObject inventoryItemPrefab;

    float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;


     // Update is called once per frame
     void Update()
     {
       // DraggableItem draggableItem = GetComponentInChildren<DraggableItem>();
       // CharacterInventory characterInventory = GetComponentInChildren<CharacterInventory>();
      ///  InventorySlot inventorySlot  = GetComponentInChildren<InventorySlot>();
       // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed
      
    }

    public void Move()
    {
        
        InventorySlot[] mainInventory_item = characterInventory.GetSelectedItem();
        InventorySlot[] functionInventory_item = functionInventory.GetSelectedItem();
        for (int i = 0; i < mainInventory_item.Length; i++)
        {
            //Thread.Sleep(500);
            DraggableItem main_draggableItem = mainInventory_item[i].GetComponentInChildren<DraggableItem>();
            
            if (main_draggableItem.image.sprite.name == "function")
            {
                Debug.Log("Fugeveny hivas");
                for (int j = 0; j < functionInventory_item.Length; j++)
                {

                    DraggableItem function_draggableItem = functionInventory_item[j].GetComponentInChildren<DraggableItem>();
                    if (function_draggableItem.image.sprite.name == "arrowhead-up")
                    {
                        Debug.Log("fel");
                        //Debug.Log(Ditem.image.name);
                        jump = true;
                    }
                    else if (function_draggableItem.image.sprite.name == "right-arrow")
                    {
                        Debug.Log("jobbra");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(50, false, jump);
                    }
                    else if (function_draggableItem.image.sprite.name == "left-arrow")
                    {
                        Debug.Log("balra");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(-50, false, jump);
                    }
                    else
                    {
                        Debug.Log("null");
                    }
                }
            }

            else if (main_draggableItem.image.sprite.name == "arrowhead-up")
            {

                Debug.Log("fel");
                //Debug.Log(Ditem.image.name);
                jump = true;
            }
            else if (main_draggableItem.image.sprite.name == "right-arrow")
            {
                Debug.Log("jobbra");
                //Debug.Log(Ditem.image.name);
                controller.Move(50, false, jump);
            }
            else if (main_draggableItem.image.sprite.name == "left-arrow")
            {
                Debug.Log("balra");
                //Debug.Log(Ditem.image.name);
                controller.Move(-50, false, jump);
            }
            else
            {
                Debug.Log("null");
            }
            // Thread.Sleep(500);
            //await Task.Deplay(1000);
        }
        

    }

    private void FixedUpdate()
     {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false,jump);
        jump = false;
     }

    [SerializeField] private float speed;
    //private Rigidbody2D body;
    //private InventorySlot InventorySlot;


    private void Awake()
    {
        //body = GetComponent<Rigidbody2D>();
    }



    /*private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }

       *//* if(InventorySlot != null)
        {
            Debug.Log("KKSDKSAD");
        }*//*
    }*/

}
