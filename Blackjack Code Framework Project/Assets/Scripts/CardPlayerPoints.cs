using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class CardPlayerPoints : MonoBehaviour
{   

    public TextMeshProUGUI PlayerPoints; 
    public GameObject drawButton; 
    public void AddCardBtn()
    {
        PickRandomNumber(21);
    }

    public void PickRandomNumber (int maxInt)
    {
        int randomNum = Random.Range(1, maxInt+1); 
        PlayerPoints.text = randomNum.ToString(); 
    }
}
