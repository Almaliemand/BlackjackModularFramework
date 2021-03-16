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

    // These are the hand slot transforms. 
    public Transform handSlot1; 
    public Transform handSlot2; 
    public Transform handSlot3; 
    public Transform handSlot4;
    public Transform handSlot5; 
    public Transform handSlot6; 
    
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
            Instantiate (twoCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (twoCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 5)
        {
            Instantiate (threeCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (twoCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 6)
        {
            Instantiate (threeCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (threeCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 7)
        {
            Instantiate (fourCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (threeCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 8)
        {
            Instantiate (fourCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (fourCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 9)
        {
            Instantiate (fiveCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (fourCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 10)
        {
            Instantiate (fiveCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (fiveCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 11)
        {
            Instantiate (sixCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (fiveCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 12)
        {
            Instantiate (sixCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (sixCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 13)
        {
            Instantiate (sevenCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (sixCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
          if (drawnCard == 14)
        {
            Instantiate (sevenCard, handSlot1.transform.position, handSlot1.transform.rotation); 
            Instantiate (sevenCard, handSlot2.transform.position, handSlot2.transform.rotation); 
        }
    }

    void drawRandomNumber (int maxInt)
    {
        int randomNum = Random.Range(4, maxInt+1); 
        drawnCard = drawnCard + randomNum; 
        PlayerPoints.text = drawnCard.ToString(); 
    }
    
}
