using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadedNormal : MonoBehaviour
{
  public GameManager gameManager;

  //if player toutches the button, this makes the corosponding platforms appear
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      gameManager.fadedButtonPress();
    }
  }
}
