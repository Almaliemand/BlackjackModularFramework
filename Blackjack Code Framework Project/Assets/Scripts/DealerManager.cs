using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class DealerManager : MonoBehaviour
{
    public int dealerScore; 
    public int randomDealerNum; 
    public int addRandomNum; 
    public GameObject playerHitButton; 
    public GameObject playerStandButton; 
    public GameObject readyToRevealUI; 
    public TextMeshProUGUI dealerScoreText; 
    
    

    // Listed below is the series of UI's for the different victory triggers

    public GameObject dealerGreaterThanPlayerUI; 
    public GameObject dealerBustUI; 
    public GameObject playerGreaterThanDealerUI; 
    public GameObject drawUI; 

    void Start() 
    {
        dealerScore = 0; 
        GameObject betManager = GameObject.Find("BetScriptHolder");
        BettingScript bettingScript = betManager.GetComponent<BettingScript>(); 
    }

    public void onDealerTurn ()
    {
        playerHitButton.SetActive (false); 
        playerStandButton.SetActive (false); 
        randomDealerNum = Random.Range(1,21); 
        dealerScore = dealerScore + randomDealerNum; 
         if (dealerScore < 11)
        {
            addRandomNum = Random.Range(1,11); 
            dealerScore = dealerScore + addRandomNum;
            readyToRevealUI.SetActive (true);

        }

        if (dealerScore > 12 && dealerScore < 21)
        {
            addRandomNum = Random.Range(1,11);
            dealerScore = dealerScore + addRandomNum;
            readyToRevealUI.SetActive (true);
        }

         if (dealerScore > 21)
        {
            dealerScoreText.text = dealerScore.ToString();
            dealerBustUI.SetActive(true);
            readyToRevealUI.SetActive (false);  
        }

         
    }

    public void onYesReveal()
    {
        readyToRevealUI.SetActive(false);

        if (dealerScore < CardDrawingRetry.playerScore)
        {
            dealerScoreText.text = dealerScore.ToString(); 
            playerGreaterThanDealerUI.SetActive(true);
            GameObject betManager = GameObject.Find("BetScriptHolder");
            BettingScript bettingScript = betManager.GetComponent<BettingScript>();
            bettingScript.playerChips += 10; 
            bettingScript.chipPotText.text = bettingScript.playerChips.ToString();
             
            
        }

        if (dealerScore > CardDrawingRetry.playerScore)
        {
            dealerScoreText.text = dealerScore.ToString();
            dealerGreaterThanPlayerUI.SetActive(true); 
            GameObject betManager = GameObject.Find("BetScriptHolder");
            BettingScript bettingScript = betManager.GetComponent<BettingScript>();
            bettingScript.playerChips += 50;
            bettingScript.chipPotText.text = bettingScript.playerChips.ToString();
             
        }

        if (dealerScore == CardDrawingRetry.playerScore)
        {
            dealerScoreText.text = dealerScore.ToString();
            drawUI.SetActive(true);
            GameObject betManager = GameObject.Find("BetScriptHolder");
            BettingScript bettingScript = betManager.GetComponent<BettingScript>();
            bettingScript.playerChips += 0;
            bettingScript.chipPotText.text = bettingScript.playerChips.ToString();
            
        }
    }

 

}
