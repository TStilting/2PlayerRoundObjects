using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerBallController : MonoBehaviour
{
    public GameManager gamemanager;
    public Rigidbody rb;
    public Rigidbody rb2;
    public GameObject player;
    public GameObject player2;
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
        rb.velocity = new Vector3 (horizontal1, 0, vertical1) * speed;
        rb2.velocity = new Vector3 (horizontal2, 0, vertical2) * speed2;


        if (Input.GetKeyDown (KeyCode.RightShift) && onGround == true)
        {
            Jump(player, rb);
        }

        if (Input.GetKeyDown (KeyCode.Space))
        {
            Jump(player2, rb2);
        }
        
        // if (onGround == true || gamemanager.active == false)
        // {    
        //     gravity = 0;
        // }
        // else
        // {
        //     gravity += versnelling * Time.deltaTime;
        // }

        // if (onGround2 == true || gamemanager.active == false)
        // {
        //     gravity2 = 0;
        // }
        // else
        // {
        //     gravity2 += versnelling2 * Time.deltaTime;
        // }
    }

    public void Jump(GameObject playerNumber, Rigidbody rbNumber)
    {
        rbNumber.AddForce(Vector3.up * jumpHeight2, ForceMode.Impulse);
    }
}