using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BettingScript : MonoBehaviour
{
    public int playerChips; 
    public int chipsLeft; 
    public int dealerChips;  
    public GameObject betUI; 
    public TextMeshProUGUI chipPotText; 
    public TextMeshProUGUI chipReserveText; 
   
     
     void Start() 
     {
        playerChips = 0;
        chipsLeft = 1000; 
        chipPotText.text = playerChips.ToString(); 
        chipReserveText.text = chipsLeft.ToString();
     }

    public void onBetOpenMenu ()
    {
        betUI.SetActive(true); 
    }

    public void onBetOneChip ()
    {
        if (chipsLeft >= 1)
        {
            playerChips += 1; 
            chipsLeft -= 1; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString(); 
             
        }  
    }

    public void onBetFiveChips ()
    {
        if (chipsLeft >= 5)
        {
            playerChips += 5; 
            chipsLeft -= 5; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onBetTenChips ()
    {
        if (chipsLeft >= 10)
        {
            playerChips += 10; 
            chipsLeft -= 10; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onBetTwentyChips ()
    {
        if (chipsLeft >= 20)
        {
            playerChips += 20; 
            chipsLeft -= 20; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onBetFiftyChips ()
    {
        if (chipsLeft >= 50)
        {
            playerChips += 50; 
            chipsLeft -= 50; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onBetHundredChips ()
    {
        if (chipsLeft >= 100)
        {
            playerChips += 100;
            chipsLeft -= 100;  
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onBetTwoHundredChips ()
    {
        if (chipsLeft >= 200)
        {
            playerChips += 200; 
            chipsLeft -= 200; 
            chipPotText.text = playerChips.ToString();
            chipReserveText.text = chipsLeft.ToString();
            
        }
    }

    public void onCancelBet ()
    {
        betUI.SetActive (false); 
    }





    


}
