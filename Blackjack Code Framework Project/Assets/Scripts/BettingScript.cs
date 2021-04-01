using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BettingScript : MonoBehaviour
{
    public int playerChips; 
    public int playerChipsReserve; 
    public GameObject betUI; 
    public TextMeshProUGUI chipPotText; 
    public TextMeshProUGUI chipReserveText; 
     
     void Start() 
     {
        playerChips = 0;
        playerChipsReserve = 1000; 
        chipPotText.text = playerChips.ToString(); 
        chipReserveText.text = playerChipsReserve.ToString();
     }

    public void onBetOpenMenu ()
    {
        betUI.SetActive(true); 
    }

    public void onBetOneChip ()
    {
        if (playerChipsReserve >= 1)
        {
            playerChips += 1; 
            playerChipsReserve -= 1; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString(); 
        }  
    }

    public void onBetFiveChips ()
    {
        if (playerChipsReserve >= 5)
        {
            playerChips += 5; 
            playerChipsReserve -= 5; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onBetTenChips ()
    {
        if (playerChipsReserve >= 10)
        {
            playerChips += 10; 
            playerChipsReserve -= 10; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onBetTwentyChips ()
    {
        if (playerChipsReserve >= 20)
        {
            playerChips += 20; 
            playerChipsReserve -= 20; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onBetFiftyChips ()
    {
        if (playerChipsReserve >= 50)
        {
            playerChips += 50; 
            playerChipsReserve -= 50; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onBetHundredChips ()
    {
        if (playerChipsReserve >= 100)
        {
            playerChips += 100;
            playerChipsReserve -= 100;  
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onBetTwoHundredChips ()
    {
        if (playerChipsReserve >= 200)
        {
            playerChips += 200; 
            playerChipsReserve -= 200; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = playerChipsReserve.ToString();
        }
    }

    public void onCancelBet ()
    {
        betUI.SetActive (false); 
    }
}
