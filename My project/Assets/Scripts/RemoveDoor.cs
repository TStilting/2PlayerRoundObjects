using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDoor : MonoBehaviour
{
    public OpenDoor openDoor;
    public OpenDoor openDoor2;
    public GameObject button;
    public GameObject button2;

    void Update()
    {
        Open();
    }

    public void Open()
    {
        if (openDoor.keyButton == true && openDoor2.keyButton == true)
        {
            this.gameObject.SetActive(false);
            button.SetActive(false);
            button2.SetActive(false);
        }
    }
}
