using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack: MonoBehaviour
{
    public GameManager gameManager;
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(goBack);   
    }

    void goBack()
    {
        gameManager.hideCredits();
    }
}
