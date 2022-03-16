using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDoor : MonoBehaviour
{
    public OpenDoor openDoor;
    public OpenDoor openDoor2;
    public GameObject button;
    public GameObject button2;

    //the update function in this script checks at all times if the boolean from OpenDoor are true...
    void Update()
    {
        Open();
    }

    //...and is told here what its supposed to do in this function...
    public void Open()
    {
        //...but only works if 2 buttons are activated at the same time
        if (openDoor.keyButton == true && openDoor2.keyButton == true)
        {
            this.gameObject.SetActive(false);
            button.SetActive(false);
            button2.SetActive(false);
        }
    }
}
