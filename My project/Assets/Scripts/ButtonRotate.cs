using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
  public GameObject platform;
  public GameObject reversePlatform;
  public GameObject singlePlatform;

  private void OnTriggerStay(Collider other)
  {
    if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
    {
      platform.transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
      reversePlatform.transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
      singlePlatform.transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
    }
  }
}
