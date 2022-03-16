using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour
{
    public GameManager gameManager;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(allowPlay);   
    }

    //makes the call to the gamamanager to start the game
    void allowPlay()
    {
        gameManager.playStart();   
    }
}
