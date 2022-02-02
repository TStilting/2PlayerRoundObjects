using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{

  public Rigidbody rb;
  public CharacterController movement;
  public float speed;
  public float gravity;
  public Vector3 playerGravity;
  public Vector3 moving;
  public int jumpHeight;

  void Update()
  {
    var horizontal1 = Input.GetAxis("Horizontal1");
    var vertical1 = Input.GetAxis("Vertical1");
    if(movement.isGrounded == false) 
    {
      moving.y -= gravity * Time.deltaTime;
    }


    moving = new Vector3(horizontal1, moving.y, vertical1);        
    movement.Move(moving * Time.deltaTime * speed);

    if (moving.y <= 0 && movement.isGrounded)
    {
      moving.y = 0;
    }
        
    if (Input.GetKeyDown(KeyCode.RightShift) && movement.isGrounded)
    {
      moving.y = jumpHeight;
    }
  }  
}