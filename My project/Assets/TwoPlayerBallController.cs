using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerBallController : MonoBehaviour
{
    //Hier maak je je eigen code voor character controller.
  public Rigidbody rb;
  public Rigidbody rb2;
  public CharacterController movement;
  public float speed;
  public float gravity;
  public Vector3 playerGravity;
  public Vector3 moving;
  public Vector3 moving2;
  public int jumpHeight;
  public bool onGround;
  public ArrayList direction;

    void Update()
    {
        moving = rb.position;
        moving2 = rb2.position;
        float horizontal1 = Input.GetAxis("Horizontal1");
        float vertical1 = Input.GetAxis("Vertical1");
        float horizontal2 = Input.GetAxis("Horizontal2");
        float vertical2 = Input.GetAxis("Vertical2");  
        rb.transform.position = new Vector3(horizontal1, 0, vertical1) * speed * Time.deltaTime;
        rb2.transform.position = new Vector3(horizontal2, 0, vertical2) * speed * Time.deltaTime;
        
        //Check voor grounded voor beide players.(met raycast op floer of ontriggerstay)
        if (onGround == true)
        {

        }
        //Check voor alle keys down en up en sla dit in een array op. 
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "")
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }
    }
}