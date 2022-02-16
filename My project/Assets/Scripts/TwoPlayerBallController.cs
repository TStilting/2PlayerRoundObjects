using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerBallController : MonoBehaviour
{
    public GameManager gamemanager;
    public Rigidbody rb;
    public Rigidbody rb2;
    public float speed;
    public float speed2;
    public float gravity;
    public float gravity2;
    public Vector3 moving;
    public Vector3 moving2;
    public int jumpHeight;
    public int jumpHeight2;
    public bool onGround;
    public bool onGround2;
    public float versnelling;
    public float versnelling2;

    void FixedUpdate()
    {
        moving = rb.position;
        moving2 = rb2.position;
        float horizontal1 = Input.GetAxis("Horizontal1");
        float vertical1 = Input.GetAxis("Vertical1");
        float horizontal2 = Input.GetAxis("Horizontal2");
        float vertical2 = Input.GetAxis("Vertical2");
        rb.velocity = new Vector3 (horizontal1, gravity, vertical1) * speed;
        rb2.velocity = new Vector3 (horizontal2, gravity2, vertical2) * speed2;



        
        if (onGround == true || gamemanager.active == false)
        {    
            gravity = 0;
        }
        else
        {
            gravity += versnelling * Time.deltaTime;
        }

        if (onGround2 == true || gamemanager.active == false)
        {
           gravity2 = 0;
        }
        else
        {
            gravity2 += versnelling2 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightShift) && onGround == true)
        {
            Jump(1);
        }

        if (Input.GetKey(KeyCode.Space) && onGround2 == true)
        {
            Jump(2);
        }
    }

    public void Jump(int playerNumber)
    {
        if(playerNumber == 1)
        {
            gravity = jumpHeight;
            onGround = false;
        }

        if(playerNumber == 2)
        {
            gravity2 = jumpHeight2;
            onGround2 = false;
        }
    }
}