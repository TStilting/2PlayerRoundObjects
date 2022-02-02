using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadedNormal : MonoBehaviour
{
  public GameManager gameManager;

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      gameManager.fadedButtonPress();
    }
  }
}
