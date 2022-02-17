using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public GameObject rankPannel;
  public GameObject timer;
  public TextMeshProUGUI timeText;
  public TextMeshProUGUI rank;
  public TextMeshProUGUI finalRank;
  public TextMeshProUGUI finalTime;
  public GameObject warning;
  public GameObject player1;
  public GameObject player2;
  public GameObject titleScreen;
  public GameObject gameOverScreen;
  public GameObject resultScreen;
  public ParticleSystem platinum;
  public ParticleSystem gold;
  public ParticleSystem silver;
  public ParticleSystem bronze;
  public GameObject restartButton;
  public bool active = false;
  private int timeSeconds;
  private int time10Seconds;
  private int timeMinutes;
  public GameObject normalPlatform;
  public GameObject invertedPlatform;

  public void playStart()
  {
    active = true;
    rank.text = "S";
    player1.SetActive(true);
    player2.SetActive(true);
    titleScreen.SetActive(false);
    StartCoroutine(TimeCounter());
    timeSeconds = 1;
  }

  IEnumerator TimeCounter()
  {
    while (active)
    {
      yield return new WaitForSeconds(1);
      timeText.text = "" + timeMinutes + ":" + time10Seconds + timeSeconds++;

      if (timeSeconds == 10)
      {
        timeSeconds = 0;
        time10Seconds++;
      }

      if (time10Seconds == 6)
      {
        time10Seconds = 0;
        timeMinutes++;
      }

      if (timeMinutes == 3 && time10Seconds == 2 && timeSeconds == 0)
      {
        rank.text = "A";
      }
          
      if (timeMinutes == 3 && time10Seconds == 5 && timeSeconds == 0)
      {
        rank.text = "B";
      }

      if (timeMinutes == 4 && time10Seconds == 3 && timeSeconds == 0)
      {
        rank.text = "C";
      }
    }
  }
  
  public void fadedButtonPress()
  {
    normalPlatform.gameObject.SetActive(true);
    invertedPlatform.gameObject.SetActive(false);
  }

  public void invertedFadedButtonPress()
  {
    normalPlatform.gameObject.SetActive(false);
    invertedPlatform.gameObject.SetActive(true);
  }

  public void gameOver()
  { 
    active = false;
    player1.SetActive(false);
    player2.SetActive(false);
    rankPannel.SetActive(false);
    timer.SetActive(false);
    warning.SetActive(false);
    rank.text = "-";
    timeText.text = "-:--";
    gameOverScreen.gameObject.SetActive(true);
    restartButton.gameObject.SetActive(true);
  }

  public void result()
  {
    active = false;
    player1.SetActive(false);
    player2.SetActive(false);
    rankPannel.SetActive(false);
    timer.SetActive(false);
    resultScreen.gameObject.SetActive(true);
    restartButton.gameObject.SetActive(true);
    finalRank.text = rank.text;
    finalTime.text = timeText.text;

    if (rank.text == "S")
    {
      platinum.Play();
    }

    else if (rank.text == "A")
    {
      gold.Play();
    }

    else if (rank.text == "B")
    {
      silver.Play(); 
    }

    else if (rank.text == "C")
    {
      bronze.Play();
    }
  }
  public void Reload()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
