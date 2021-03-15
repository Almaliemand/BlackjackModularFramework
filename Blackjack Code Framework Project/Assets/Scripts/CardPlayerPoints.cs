using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class CardPlayerPoints : MonoBehaviour
{   
    // This is to make the UI element showing the player's score accessible in the editor.

    public TextMeshProUGUI PlayerPoints; 
    
    // This button appears at the start of the game to allow players to draw their cards. Disappears after being pressed, gives random value between 1 - 21.
    public GameObject drawButton; 
    
    // This button appears after draw button is pressed. Adds a random number to the total. 
    public GameObject addButton;

    // The function to be bound to the draw button. 
    public void DrawCardBtn()
    {
        PickRandomNumber(21);
        drawButton.SetActive (false); 
        addButton.SetActive (true); 
    }

    private void PickRandomNumber (int maxInt)
    {
        int randomNum = Random.Range(1, maxInt+1); 
        PlayerPoints.text = randomNum.ToString(); 
    }
}
