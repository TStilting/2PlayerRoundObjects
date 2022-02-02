using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public GameManager gameManager;
    private Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(allowPlay);   
    }

    void allowPlay()
    {
        gameManager.playStart();   
    }
}
