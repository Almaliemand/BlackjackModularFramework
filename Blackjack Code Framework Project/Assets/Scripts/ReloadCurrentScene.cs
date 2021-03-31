using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ReloadCurrentScene : MonoBehaviour
{
    public void onBtnPress (int MainSceneNumber)
    {
       SceneManager.LoadScene(0); 
    }
}
