using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failed : MonoBehaviour
{
  public GameManager gameManager;

  //if player toutches the bottom floor, this makes the gamemanager call the corrosponding game over method
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      gameManager.gameOver();
    }
  }
}
