using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDoor3 : MonoBehaviour
{
    public OpenDoor5 openDoor5;
    public OpenDoor6 openDoor6;

    void Update()
    {
        Open();
    }

    public void Open()
    {
        if (openDoor5.keyButton == true && openDoor6.keyButton == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
