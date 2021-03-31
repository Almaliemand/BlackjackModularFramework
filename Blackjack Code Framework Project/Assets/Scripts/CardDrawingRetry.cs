﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class CardDrawingRetry : MonoBehaviour
{

    int playerScore = 0; 
    public TextMeshProUGUI playerScoreText; 
    public GameObject bustFailUI; 

    // Below is a list of card game objects that the script will instantiate later on. 

    public GameObject oneCard; 
    public GameObject twoCard;
    public GameObject threeCard;
    public GameObject fourCard;
    public GameObject fiveCard;
    public GameObject sixCard;
    public GameObject sevenCard;
    public GameObject eightCard;
    public GameObject nineCard;
    public GameObject tenCard;
    public void onBtnPress()
    {
        int randomNum = Random.Range (1,10); 
        playerScore = playerScore + randomNum; 
        playerScoreText.text = playerScore.ToString(); 
        if (playerScore > 21)
        {
            bustFailUI.SetActive (true); 
        }

        // Below is the list of cards that the script must instantiate based on the random number generated. 
        if (randomNum == 1)
        {
            Instantiate (oneCard); 
        }

        if (randomNum == 2)
        {
            Instantiate (twoCard); 
        }

        if (randomNum == 3)
        {
            Instantiate (threeCard); 
        }

        if (randomNum == 4)
        {
            Instantiate (fourCard); 
        }

        if (randomNum == 5)
        {
            Instantiate (fiveCard); 
        }

        if (randomNum == 6)
        {
            Instantiate (sixCard); 
        }

        if (randomNum == 7)
        {
            Instantiate (sevenCard); 
        }

        if (randomNum == 8)
        {
            Instantiate (eightCard); 
        }

        if (randomNum == 9)
        {
            Instantiate (nineCard); 
        }

        if (randomNum == 10)
        {
            Instantiate (tenCard); 
        }
        
    }
}
