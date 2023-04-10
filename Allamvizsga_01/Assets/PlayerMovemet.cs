using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemet : MonoBehaviour
{

     public CharacterController2D controller;

     float runSpeed = 40f;
     float horizontalMove = 0f;
     bool jump = false;


     // Update is called once per frame
     void Update()
     {

         horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

         if (Input.GetButtonDown("Jump"))
         {
             jump = true;
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
