using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCredits : MonoBehaviour
{
    public GameManager gameManager;
    public Button creditsButton;

    // Start is called before the first frame update
    void Start()
    {
        creditsButton.onClick.AddListener(credit);   
    }

    void credit()
    {
        gameManager.showCredits();
    }
}
