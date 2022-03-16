using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
  public GameManager gameManager;
  
  //if 1 of eather players crosses the object...
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      //...it tells the gamemanager to load the result screen
      gameManager.result();
    }
  }
}
