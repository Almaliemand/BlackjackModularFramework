using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class CardDrawingRetry : MonoBehaviour
{

    public int playerScore;  
    public int randomNum; 
    public TextMeshProUGUI playerScoreText; 
    public GameObject bustFailUI; 
    public GameObject aceChoiceUI; 
    public GameObject drawButton;
    public GameObject standButton; 

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
    public GameObject jackCard;
    public GameObject queenCard; 
    public GameObject kingCard; 
    public GameObject aceCard; 

    List<GameObject> cardPrefabList = new List<GameObject>();

    void Start()
    {
        cardPrefabList.Add(tenCard); 
        cardPrefabList.Add(jackCard);
        cardPrefabList.Add(queenCard);
        cardPrefabList.Add(kingCard);
    } 
    public void onBtnPress()
    {
        randomNum = Random.Range (1,11); 
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
            Debug.Log ("You got a ten!"); 
            int prefabIndex = UnityEngine.Random.Range(0,3); 
            Instantiate(cardPrefabList[prefabIndex]); 
        }

        if (randomNum == 11)
        {
            Instantiate(aceCard); 
        }


        
    }





}
