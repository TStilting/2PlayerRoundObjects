using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerBallController : MonoBehaviour
{
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

    void FixedUpdate()
    {
        moving = rb.position;
        moving2 = rb2.position;
        float horizontal1 = Input.GetAxis("Horizontal1");
        float vertical1 = Input.GetAxis("Vertical1");
        float horizontal2 = Input.GetAxis("Horizontal2");
        float vertical2 = Input.GetAxis("Vertical2");
        rb.velocity = new Vector3 (horizontal1, gravity, vertical1) * speed;
        rb2.velocity = new Vector3 (horizontal2, gravity2, vertical2) * speed;

        //Check voor grounded voor beide players.(met raycast op floer of ontriggerstay)
        if (Input.GetKeyDown (KeyCode.RightShift) && onGround == true)
        {
            rb.AddForce (0, 5, 0);
        }
        
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb2.AddForce(Vector3.up * 100, ForceMode.Impulse);
        }



        
        if (onGround == true)
        {
            
            gravity = 0;
        }
        else
        {
            gravity += versnelling * Time.deltaTime;
        }

        if (onGround2 == true)
        {
            gravity2 = 0;
        }
        else
        {
            gravity2 += versnelling * Time.deltaTime;
        }
    }
}