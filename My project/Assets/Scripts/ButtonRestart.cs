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

    //makes the call to the gamamanager to reload the scene
    void restart()
    {
        gameManager.Reload();   
    }
}
