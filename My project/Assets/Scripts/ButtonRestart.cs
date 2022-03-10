using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRestart : MonoBehaviour
{
    public GameManager gameManager;
    public Button restartButton;

    void Start()
    {
        restartButton.onClick.AddListener(restart);   
    }

    void restart()
    {
        gameManager.Reload();   
    }
}
