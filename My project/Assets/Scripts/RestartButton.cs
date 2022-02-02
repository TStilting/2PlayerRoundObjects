using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public GameManager gameManager;
    private Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        restartButton = GetComponent<Button>();
        restartButton.onClick.AddListener(restart);   
    }

    void restart()
    {
        gameManager.Reload();   
    }
}
