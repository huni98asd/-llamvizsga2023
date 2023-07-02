using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.UI;

public class PlayerMovemet : MonoBehaviour
{
    public CharacterController2D controller;
    public CharacterInventory characterInventory;
    public FunctionInventory functionInventory;
    public GameObject inventoryItemPrefab;
    public InputField variableI;
    public InputField compareI;
    public InputField operationI;
    
   

     // Update is called once per frame
    void Update()
     {
       // DraggableItem draggableItem = GetComponentInChildren<DraggableItem>();
       // CharacterInventory characterInventory = GetComponentInChildren<CharacterInventory>();
      ///  InventorySlot inventorySlot  = GetComponentInChildren<InventorySlot>();
       // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed
      
    }


    async public void Move()
    {
        
        InventorySlot[] mainInventory_item = characterInventory.GetSelectedItem();
        InventorySlot[] functionInventory_item1 = functionInventory.GetSelectedItem();
        InventorySlot[] functionInventory_item2 = functionInventory.GetSelectedItem2();

        for (int i = 0; i < mainInventory_item.Length; i++)
        {
            DraggableItem main_draggableItem = mainInventory_item[i].GetComponentInChildren<DraggableItem>();
            
            if (main_draggableItem.image.sprite.name == "f1")
            {
                Debug.Log("Fugeveny hivas");
                for (int j = 0; j < functionInventory_item1.Length; j++)
                {

                    DraggableItem function_draggableItem = functionInventory_item1[j].GetComponentInChildren<DraggableItem>();
                    Debug.Log(function_draggableItem.image.sprite.name);
                    if (function_draggableItem.image.sprite.name == "arrowhead-up")
                    {
                        Debug.Log("fel");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(false, false, true,false);
                    }
                    else if (function_draggableItem.image.sprite.name == "right-arrow")
                    {
                        Debug.Log("jobbra");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(true, false, false,false);
                    }
                    else if (function_draggableItem.image.sprite.name == "down-arrow")
                    {
                        Debug.Log("le");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(false, true, false, false);
                    }
                    else
                    {
                        Debug.Log("null");
                    }
                    await Task.Delay(1000);
                }
            }
           
            else if (main_draggableItem.image.sprite.name == "f2")
            {
                Debug.Log("Fugeveny hivas 2");
                for (int j = 0; j < functionInventory_item2.Length; j++)
                {

                    DraggableItem function_draggableItem2 = functionInventory_item2[j].GetComponentInChildren<DraggableItem>();
                    if(functionInventory_item2[j] == null)
                    {
                        Debug.Log("ures");
                    }
                    Debug.Log(function_draggableItem2.image.sprite.name);
                    if (function_draggableItem2.image.sprite.name == "arrowhead-up")
                    {
                        Debug.Log("fel");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(false, false, true, false);
                    }
                    else if (function_draggableItem2.image.sprite.name == "right-arrow")
                    {
                        Debug.Log("jobbra");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(true, false, false, false);
                    }
                    else if (function_draggableItem2.image.sprite.name == "down-arrow")
                    {
                        Debug.Log("le");
                        //Debug.Log(Ditem.image.name);
                        controller.Move(false, true, false, false);
                    }
                    else
                    {
                        Debug.Log("null");
                    }
                    await Task.Delay(1000);
                }
            }

            else if (main_draggableItem.image.sprite.name == "cycle")
            {
                Debug.Log("Ciklus inditas");
                for (int j = 0; j < 2; j++)
                
                {
                   
                    for (int x = 0; x < functionInventory_item1.Length; x++)
                    {
                        DraggableItem cycle_draggableItem = functionInventory_item1[x].GetComponentInChildren<DraggableItem>();
                        if (cycle_draggableItem.image.sprite.name == "arrowhead-up")
                        {

                            Debug.Log("fel");
                            //Debug.Log(Ditem.image.name);
                            controller.Move(false, false, true, false);
                        }
                        else if (cycle_draggableItem.image.sprite.name == "right-arrow")
                        {
                            Debug.Log("jobbra");
                            //Debug.Log(Ditem.image.name);
                            controller.Move(true, false, false, false);

                        }
                        else if (cycle_draggableItem.image.sprite.name == "down-arrow")
                        {
                            Debug.Log("le");
                            //Debug.Log(Ditem.image.name);
                            controller.Move(false, true, false, false);
                        }
                    await Task.Delay(1000);
                    }
                    Debug.Log(variableI.text);
                    Debug.Log(compareI.text);
                    Debug.Log(operationI.text);
                   
                }
            }

            else if (main_draggableItem.image.sprite.name == "arrowhead-up")
            {

                Debug.Log("fel");
                //Debug.Log(Ditem.image.name);
                controller.Move(false, false, true, false);
            }
            else if (main_draggableItem.image.sprite.name == "right-arrow")
            {
                Debug.Log("jobbra");
                //Debug.Log(Ditem.image.name);
                controller.Move(true, false, false, false);
            }
            else if (main_draggableItem.image.sprite.name == "down-arrow")
            {
                Debug.Log("le");
                //Debug.Log(Ditem.image.name);
                controller.Move(false, true, false, false);
            }
            else if (main_draggableItem.image.sprite.name == "if")
            {
                DraggableItem function_draggableItem = functionInventory_item1[0].GetComponentInChildren<DraggableItem>();
                Debug.Log(function_draggableItem.image.sprite.name);
                if (function_draggableItem.image.sprite.name == "2up-arrow")
                {
                    controller.Move(false, false, false, true);
                }
                
            }
            else
            {
                Debug.Log("null");
            }
            
            await Task.Delay(1000);
        }
        

    }

    private void FixedUpdate()
     {
       // controller.Move(true, false,jump);
        ///jump = false;
     }



    private void Awake()
    {
        //body = GetComponent<Rigidbody2D>();
    }



}
