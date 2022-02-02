using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDoor2 : MonoBehaviour
{
    public OpenDoor3 openDoor3;
    public OpenDoor4 openDoor4;

    void Update()
    {
        Open();
    }

    public void Open()
    {
        if (openDoor3.keyButton == true && openDoor4.keyButton == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}