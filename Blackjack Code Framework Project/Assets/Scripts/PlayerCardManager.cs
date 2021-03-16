using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class PlayerCardManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerPoints; 

    // These are the two buttons that needs to be bound in the inspector. 
    public GameObject drawButton; 
    public GameObject addButton; 

    // these gameobjects are used to later instantiate the cards. 
    public GameObject aceCard; 
    public GameObject twoCard;
    public GameObject threeCard; 
    public GameObject fourCard; 
    public GameObject fiveCard; 
    public GameObject sixCard; 
    public GameObject sevenCard; 
    public GameObject eightCard; 
    public GameObject nineCard; 
    public GameObject tenCard; 


 
     
    
    // this is the integer that controls the first value in the player hand. 
    int drawnCard; 

    // this is the integer that controls the value each time the player adds a card to their hand. 
    int result; 

    // This function sets the player hand's value to zero at the start of the game!
     void Start() 
    {
        drawnCard = 0; 
        PlayerPoints.text = drawnCard.ToString(); 
        
    } 

    public void onDrawBtn ()
    {
        drawRandomNumber(21); 
        drawButton.SetActive (false); 
        addButton.SetActive (true); 

        if (drawnCard == 4)
        {
            Instantiate (twoCard); 
            Instantiate (twoCard); 
        }
          if (drawnCard == 5)
        {
            Instantiate (threeCard); 
            Instantiate (twoCard); 
        }
          if (drawnCard == 6)
        {
            Instantiate (threeCard); 
            Instantiate (threeCard); 
        }
          if (drawnCard == 7)
        {
            Instantiate (fourCard); 
            Instantiate (threeCard); 
        }
          if (drawnCard == 8)
        {
            Instantiate (fourCard); 
            Instantiate (fourCard); 
        }
          if (drawnCard == 9)
        {
            Instantiate (fiveCard); 
            Instantiate (fourCard); 
        }
          if (drawnCard == 10)
        {
            Instantiate (fiveCard); 
            Instantiate (fiveCard); 
        }
          if (drawnCard == 11)
        {
            Instantiate (sixCard); 
            Instantiate (fiveCard); 
        }
          if (drawnCard == 12)
        {
            Instantiate (sixCard); 
            Instantiate (sixCard); 
        }
          if (drawnCard == 13)
        {
            Instantiate (sevenCard); 
            Instantiate (sixCard); 
        }
          if (drawnCard == 14)
        {
            Instantiate (sevenCard); 
            Instantiate (sevenCard); 
        }
            if (drawnCard == 15)
        {
            Instantiate (eightCard); 
            Instantiate (sevenCard); 
        }
            if (drawnCard == 16)
        {
            Instantiate (eightCard); 
            Instantiate (eightCard); 
        }
            if (drawnCard == 17)
        {
            Instantiate (nineCard); 
            Instantiate (eightCard); 
        }
            if (drawnCard == 18)
        {
            Instantiate (nineCard); 
            Instantiate (nineCard); 
        }
            if (drawnCard == 19)
        {
            Instantiate (tenCard); 
            Instantiate (nineCard); 
        }
            if (drawnCard == 20)
        {
            Instantiate (tenCard); 
            Instantiate (tenCard); 
        }
            if (drawnCard == 21)
            {
            Instantiate (tenCard);
            Instantiate (aceCard); 
            }
    }

    void drawRandomNumber (int maxInt)
    {
        int randomNum = Random.Range(4, maxInt+1); 
        drawnCard = drawnCard + randomNum; 
        PlayerPoints.text = drawnCard.ToString(); 
    }
    
}
