using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForGround : MonoBehaviour
{
    public TwoPlayerBallController twoPlayerBallController;
    public bool  option1 = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Ground")
        {
            if(option1)
            {
                twoPlayerBallController.onGround = true;
            }
            else
            {
                twoPlayerBallController.onGround2 = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Ground")
        {
            if(option1)
            {
                twoPlayerBallController.onGround = false;
            }
            else
            {
                twoPlayerBallController.onGround2 = false;
            }
        }
    }
}
