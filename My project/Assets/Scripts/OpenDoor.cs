using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
  public bool keyButton;

  //if any player stands on the button, its returns the boolean true...
  private void OnTriggerStay(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      keyButton = true;
    }
  }

  //...but also returns the boolean false if the player leaves the button
  private void OnTriggerExit(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      keyButton = false;
    }
  }
}
