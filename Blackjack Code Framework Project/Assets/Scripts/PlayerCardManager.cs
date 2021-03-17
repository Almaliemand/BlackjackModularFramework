using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class PlayerCardManager : MonoBehaviour
{
    //The UI element showing the initial value of the hand dealt to the player.
    public TextMeshProUGUI PlayerPointsInitial; 

    // This UI element shows the score of the player each time they add a card. 
    public TextMeshProUGUI PlayerPointsTrue; 

    // These are the two buttons that needs to be bound in the inspector. 
    public GameObject drawButton; 
    public GameObject addButton; 

    // this is the fail screen that appears when the player busts. 
    public GameObject bustfailUI; 

    // these gameobjects are used to  instantiate the cards. 
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

    // this is the limit of the points, anything greater will lose you the game.
    int pointLimit = 21; 

    int addResult; 

    // This function sets the player hand's value to zero at the start of the game!
     void Start() 
    {
        drawnCard = 0; 
        PlayerPointsInitial.text = drawnCard.ToString(); 
        PlayerPointsTrue.enabled = false; 
        
    } 

    public void onDrawBtn ()
    {
        drawRandomNumber();  
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

    public void onAddBtn ()
    {
        addRandomNumber(); 
        PlayerPointsInitial.enabled = false; 
        PlayerPointsTrue.enabled = true;

          if (addResult > 21)
        {
            bustfailUI.SetActive (true); 
            addButton.SetActive (false); 
        }

    
    }

  



    void drawRandomNumber ()
    {
        int randomNum = Random.Range(4, 21); 
        drawnCard = drawnCard + randomNum; 
        PlayerPointsInitial.text = drawnCard.ToString(); 
    }

    void addRandomNumber ()
    {
        int addRandomNum = Random.Range(1, 11); 
        addResult = addResult + addRandomNum; 
        addResult = drawnCard += addRandomNum; 
        PlayerPointsTrue.text = addResult.ToString();  
    }



 


 
    
}
